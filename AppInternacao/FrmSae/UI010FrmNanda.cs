﻿using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI010FrmNanda : UI000FrmTemplate
    {
        private readonly bool isSAE;

        public UI010FrmNanda(bool _isSae = false)
        {
            InitializeComponent();
            dataGridViewFatoresRelacionados.AutoGenerateColumns = false;
            dataGridViewCaracteristicasDefinidoras.AutoGenerateColumns = false;
            dataGridViewCondicoesAssociada.AutoGenerateColumns = false;
            dataGridViewPopulacaoRisco.AutoGenerateColumns = false;
            dataGridViewFatoresRiscos.AutoGenerateColumns = false;
            isSAE = _isSae;
        }

        PresenterGeneric presenterGeneric = null;
        List<NandaDominio> nandaDominios = null;
        List<NandaClasse> nandaClasses = null;
        List<NandaFatorRelacionado> nandaFatorRelacionados = null;
        List<NandaCaracteristicaDefinidora> nandaCaracteristicaDefinidoras = null;
        List<NandaDiagnostico> nandaDiagnosticos = null;
        List<NandaCondicaoAssociada> nandaCondicaoAssociadas = null;
        List<NandaFatorRisco> nandaFatorRiscos = null;
        List<NandaPopulacaoRisco> nandaPopulacaoRiscos = null;
        TreeNode nRoot;

        private void UI010FrmNanda_Load(object sender, EventArgs e)
        {
            if (isSAE)
            {
                FrmMain.listButtons.ForEach(b => 
                { 
                     if(b.Name.Equals("btnAddDiagnostico"))
                    {
                        b.Visible = true;
                        b.Click += AddDiagnostrico_Click;
                    }
                });

                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStep_Click;
            }
            presenterGeneric = new PresenterGeneric();
            nandaDominios = presenterGeneric.GetLista(new NandaDominio(), Procedure.SP_GET_DOMINIO);
            nandaClasses = presenterGeneric.GetLista(new NandaClasse(), Procedure.SP_GET_CLASSE);
            nandaFatorRelacionados = presenterGeneric.GetLista(new NandaFatorRelacionado(), Procedure.SP_GET_FATORES_RELACIONADOS);
            nandaCaracteristicaDefinidoras = presenterGeneric.GetLista(new NandaCaracteristicaDefinidora(), Procedure.SP_GET_CARACTERISTICA_DEFINIDORA);
            nandaDiagnosticos = presenterGeneric.GetLista(new NandaDiagnostico(), Procedure.SP_GET_DIAGNOSTICO);
            nandaCondicaoAssociadas = presenterGeneric.GetLista(new NandaCondicaoAssociada(), Procedure.SP_GET_CONDICOES_ASSOCIADA);
            nandaFatorRiscos = presenterGeneric.GetLista(new NandaFatorRisco(), Procedure.SP_GET_FATORES_RISCO);
            nandaPopulacaoRiscos = presenterGeneric.GetLista(new NandaPopulacaoRisco(), Procedure.SP_GET_POPULACAO_RISCO);

            nRoot = new TreeNode("Diagnósticos Nanda");
            FilterByName();
        }

        private void FilterByName()
        {
            try
            {
                nRoot.Nodes.Clear();
                treeView1.Nodes.Clear();
                NandaClasse objNandaClasse = null;

                if (string.IsNullOrWhiteSpace(textBoxPesquisaDiagnostico.Text.Trim()))
                {
                    nandaDominios.ForEach(n =>
                    {
                        nRoot.Nodes.Add(new TreeNode { Text = $"Domínio {n.Id} {n.Dominio}", Tag = n.Id });
                    });

                    foreach (TreeNode item in nRoot.Nodes)
                    {
                        nandaClasses.ForEach(c =>
                        {
                            if (c.IdDominio.Equals(item.Tag))
                                if (!item.Nodes.ContainsKey($"cla{c.IdClasse}"))
                                {
                                    item.Nodes.Add(new TreeNode { Text = $"Classe {c.IdClasse} {c.Classe}", Tag = c, Name = $"cla{c.IdClasse}" });

                                    foreach (TreeNode itemDiag in item.Nodes)
                                    {
                                        objNandaClasse = (NandaClasse)itemDiag.Tag;
                                        nandaDiagnosticos.Where(n => n.IdDominio == objNandaClasse.IdDominio && n.IdClasse == objNandaClasse.IdClasse)
                                        .ToList().ForEach(d =>
                                        {
                                            if (!itemDiag.Nodes.ContainsKey(d.Codigo.Trim()))
                                                itemDiag.Nodes.Add(new TreeNode { Text = d.Diagnostico, Name = d.Codigo.Trim(), Tag = d });
                                        });
                                    }
                                }
                        });
                    }
                }
                else
                {
                    List<NandaDiagnostico> lstDiagnosttico = nandaDiagnosticos.Where(d => d.Diagnostico.ToUpper().Contains(textBoxPesquisaDiagnostico.Text.Trim()) || d.Codigo.StartsWith(textBoxPesquisaDiagnostico.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
                    List<NandaClasse> lstClasse = nandaClasses.Where(c => lstDiagnosttico.Any(d => d.Codigo == c.Codigo)).ToList();
                    List<NandaDominio> lstDominio = nandaDominios.Where(d => lstClasse.Any(c => c.IdDominio == d.Id && lstDiagnosttico.Any(g => g.Codigo == c.Codigo))).ToList();

                    lstDominio.ForEach(n =>
                    {
                        nRoot.Nodes.Add(new TreeNode { Text = $"Domínio {n.Id} {n.Dominio}", Tag = n });
                    });

                    NandaDominio objDominio = null;
                    foreach (TreeNode item in nRoot.Nodes)
                    {
                        objDominio = (NandaDominio)item.Tag;
                        lstClasse.ForEach(c =>
                        {
                            if (c.IdDominio.Equals(objDominio.Id))
                                if (!item.Nodes.ContainsKey($"cla{c.IdClasse}"))
                                {
                                    item.Nodes.Add(new TreeNode { Text = $"Classe {c.IdClasse} {c.Classe}", Tag = c, Name = $"cla{c.IdClasse}" });

                                    foreach (TreeNode itemDiag in item.Nodes)
                                    {
                                        objNandaClasse = (NandaClasse)itemDiag.Tag;
                                        lstDiagnosttico.Where(n => n.IdDominio == objNandaClasse.IdDominio && n.IdClasse == objNandaClasse.IdClasse)
                                        .ToList().ForEach(d =>
                                        {
                                            if (!itemDiag.Nodes.ContainsKey(d.Codigo.Trim()))
                                                itemDiag.Nodes.Add(new TreeNode { Text = d.Diagnostico, Name = d.Codigo.Trim(), Tag = d });
                                        });
                                    }
                                }
                        });
                    }

                    nRoot.ExpandAll();
                }

                treeView1.Nodes.Add(nRoot);
                nRoot.Expand();
            }
            catch (Exception exFilter)
            {
                FrmMain.Alert(exception: exFilter);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {

                if (e.Node.Tag == null || e.Node.Level < 3)
                    return;

                NandaDiagnostico objNandaDiagnostico = (NandaDiagnostico)e.Node.Tag;
                lblDominio.Text = e.Node.Parent.Parent.Text;
                lblClasse.Text = e.Node.Parent.Text;
                textBoxDefinicao.Text = objNandaDiagnostico.Definicao;
                lblTituloDiagnostico.Text = $"Diagnóstico: {objNandaDiagnostico.Codigo} - {objNandaDiagnostico.Diagnostico}";
                dataGridViewFatoresRelacionados.DataSource = nandaFatorRelacionados.Where(f => f.Codigo.Trim() == objNandaDiagnostico.Codigo.Trim()).ToList();
                dataGridViewCaracteristicasDefinidoras.DataSource = nandaCaracteristicaDefinidoras.Where(c => c.Codigo.Trim() == objNandaDiagnostico.Codigo.Trim()).ToList();
                dataGridViewCondicoesAssociada.DataSource = nandaCondicaoAssociadas.Where(a => a.Codigo.Trim() == objNandaDiagnostico.Codigo.Trim()).ToList();
                dataGridViewFatoresRiscos.DataSource = nandaFatorRiscos.Where(t => t.Codigo.Trim() == objNandaDiagnostico.Codigo.Trim()).ToList();
                dataGridViewPopulacaoRisco.DataSource = nandaPopulacaoRiscos.Where(p => p.Codigo.Trim() == objNandaDiagnostico.Codigo.Trim()).ToList();
                dataGridViewCondicoesAssociada.ClearSelection();
                dataGridViewCaracteristicasDefinidoras.ClearSelection();
                dataGridViewFatoresRelacionados.ClearSelection();
                dataGridViewFatoresRiscos.ClearSelection();
                dataGridViewPopulacaoRisco.ClearSelection();

            }
            catch (Exception exTree)
            {
                FrmMain.Alert(exception: exTree);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            lblClasse.Text = "Classe:";
            lblDominio.Text = "Domínio:";
            lblTituloDiagnostico.Text = "Diagnóstico:";
            textBoxDefinicao.Text = string.Empty;
            dataGridViewCaracteristicasDefinidoras.DataSource = null;
            dataGridViewCondicoesAssociada.DataSource = null;
            dataGridViewFatoresRelacionados.DataSource = null;
            dataGridViewFatoresRiscos.DataSource = null;
            dataGridViewPopulacaoRisco.DataSource = null;
            textBoxPesquisaDiagnostico.Text = string.Empty;
            textBoxPesquisaDiagnostico.Focus();

            foreach (TreeNode item in treeView1.Nodes[0].Nodes)
            {
                if (item.IsExpanded)
                    item.Collapse();
            }
            
        }

        private void textBoxPesquisaDiagnostico_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPesquisaDiagnostico.Text))
            {
                FilterByName();
                return;
            }
            if (textBoxPesquisaDiagnostico.Text.Length > 4)
                FilterByName();
        }

        private void BtnVizualizarDiagnostico_Click(object sender, EventArgs e)
        {
            
            var f = new UI013FrmSaeViewDiagnostico() { TopLevel = false };
            UI011FrmTimeLine.ctrl.Controls.Add(f);
            f.BringToFront();
            f.Show();

            UI011FrmTimeLine.iconButtonAvanca.Enabled = UI011FrmTimeLine.IconButtonVolta.Enabled = false;
        }

        private void AddDiagnostrico_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(treeView1?.SelectedNode?.Level > 2))
                {
                    MessageBox.Show("Selecione um diagnóstico e e seus items relacionados","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DiagnosticoEnfermagem diagnosticoEnfermagem = new DiagnosticoEnfermagem();

                diagnosticoEnfermagem.Diagnostico = (NandaDiagnostico)treeView1.SelectedNode.Tag;
                diagnosticoEnfermagem.NomeDominio = nandaDominios.FirstOrDefault(d => d.Id.Equals(diagnosticoEnfermagem.Diagnostico.IdDominio)).Dominio;
                diagnosticoEnfermagem.NomeClasse = nandaClasses.FirstOrDefault(s => s.Codigo.Equals(diagnosticoEnfermagem.Diagnostico.Codigo)).Classe;

                if (Sessao.Paciente.Sae.DiagnosticoEnfermagem.Exists(x => x.Diagnostico.Codigo.Equals(diagnosticoEnfermagem.Diagnostico.Codigo)))
                {
                    MessageBox.Show("Você já adicionou esse diagnóstico na lista.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DataGridViewSelectedRowCollection dataGridViewSelected = dataGridViewFatoresRelacionados.SelectedRows;
                if (dataGridViewSelected.Count > 0)
                    foreach (DataGridViewRow item in dataGridViewSelected)
                        diagnosticoEnfermagem.FatorRelacionados.Add((NandaFatorRelacionado)item.DataBoundItem);

                dataGridViewSelected = dataGridViewCaracteristicasDefinidoras.SelectedRows;
                if (dataGridViewSelected.Count > 0)
                    foreach (DataGridViewRow item in dataGridViewSelected)
                        diagnosticoEnfermagem.CaracteristicaDefinidoras.Add((NandaCaracteristicaDefinidora)item.DataBoundItem);

                dataGridViewSelected = dataGridViewCondicoesAssociada.SelectedRows;
                if (dataGridViewSelected.Count > 0)
                    foreach (DataGridViewRow item in dataGridViewSelected)
                        diagnosticoEnfermagem.CondicaoAssociadas.Add((NandaCondicaoAssociada)item.DataBoundItem);

                dataGridViewSelected = dataGridViewFatoresRiscos.SelectedRows;
                if (dataGridViewSelected.Count > 0)
                    foreach (DataGridViewRow item in dataGridViewSelected)
                        diagnosticoEnfermagem.FatorRiscos.Add((NandaFatorRisco)item.DataBoundItem);

                dataGridViewSelected = dataGridViewPopulacaoRisco.SelectedRows;
                if (dataGridViewSelected.Count > 0)
                    foreach (DataGridViewRow item in dataGridViewSelected)
                        diagnosticoEnfermagem.PopulacaoRiscos.Add((NandaPopulacaoRisco)item.DataBoundItem);

                Sessao.Paciente.Sae.DiagnosticoEnfermagem.Add(diagnosticoEnfermagem);
                BtnVizualizarDiagnostico.Visible = true;
                BtnVizualizarDiagnostico.Enabled = Sessao.Paciente.Sae.DiagnosticoEnfermagem.Count > 0;
                BtnVizualizarDiagnostico.Text = $"Visualizar iten(s) {Sessao.Paciente.Sae.DiagnosticoEnfermagem.Count }";
            }
            catch (Exception ex)
            {
                FrmMain.Alert(Alerts.ErrorException, exception: ex);
            }
        }

        private void btnButtonStep_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);

                Form frm = new UI016FrmIntervencaoEnfermagem() { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                UI011FrmTimeLine.lblRotuloSae.Text = "Prescrição - Intervenção de Enfermagem";
                frm.Show();
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }

        }
    }
}
