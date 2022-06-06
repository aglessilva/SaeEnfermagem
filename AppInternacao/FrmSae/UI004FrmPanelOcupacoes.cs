using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI004FrmPanelOcupacoes : UI000FrmTemplate
    {
        public UI004FrmPanelOcupacoes()
        {
            InitializeComponent();
        }

        RadioButton pictureBoxLeito = null;
        List<Leito> leitos = null;
        List<Quarto> quartos = null;
        ToolTip toolTip = null;
        LeitoPresenter presenterLeito = null;

        private void UI004FrmPanelOcupacoes_Load(object sender, EventArgs e)
        {
            try
            {
                FrmMain.listButtons.ForEach(b =>
                {
                    if (b.Name.Equals("btnSalvar"))
                    {
                        b.Visible = b.Enabled = !(FrmMain.myNovo.Visible = FrmMain.myImprimir.Visible = false);
                        b.IconChar = IconChar.Save;
                        b.Click += MySalvar_Click;
                        b.Width = 80;
                        b.Text = "Salvar".Trim();
                    }
                });

                presenterLeito = new LeitoPresenter();
                leitos = presenterLeito.GetListLeitos();
                quartos = presenterLeito.GetListQuartos();
                quartos.Insert(0, new Quarto { Id = 0, NomeQuarto = "Todos" });

                comboBoxPesquisaQuarto.DataSource = quartos;
                PopulaOcupacoes();
                comboBoxPesquisaQuarto.SelectedIndexChanged += comboBoxPesquisaQuarto_SelectedIndexChanged;
            }
            catch (Exception exLoadForms)
            {
                FrmMain.Alert(exception: exLoadForms);
            }
        }

        private void MySalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = Sessao.Paciente;
                if (paciente != null)
                {
                    RadioButton radioButton = flowLayoutPanelImgLeito.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);

                    if (radioButton == null)
                    {
                        MessageBox.Show("Selecione um Leito disponivel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    var obj = (Leito)radioButton.Tag;

                    if (obj.IsManutencao)
                    {
                        MessageBox.Show("Leito em MANUTENÇÃO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    string msg = $"Tem certeza que deseja associar o paciente {paciente.Nome} ao leito {obj.NomeLeito}?";

                    if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        obj.IsDisponibilidade = false;
                        obj.Prontuario = paciente.Prontuario;
                        obj.Nome = string.Empty;
                        obj.Act = 'X';
                        presenterLeito.Salvar(obj,false);

                        // Atualiza Statuso de parciente para Internado
                        paciente.Status = Enum.StatusInternacao.Internado;
                        paciente.NomeLeito = paciente.NomeSetor = paciente.NomeQuarto = null;
                        new PacientePresenter().Salvar(paciente);
                        AtualizaUserControls();
                    }
                }
                else
                    MessageBox.Show("Selecione um paciente na lista ao lado, e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Sessao.Paciente = null;
                paciente = null;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex); 
            }
        }

        void PopulaOcupacoes(int _id = 0)
        {
            flowLayoutPanelImgLeito.Controls.Clear();
            List<Leito> lst = _id == 0 ? leitos : leitos.Where(l => l.IdQuarto == _id).ToList();

            lst.ForEach(l =>
            {

                pictureBoxLeito = new RadioButton();
                pictureBoxLeito.TextAlign = ContentAlignment.TopLeft;
                pictureBoxLeito.ForeColor = Color.DarkSlateGray;
                toolTip = new ToolTip() { IsBalloon = true, UseAnimation = true };
                pictureBoxLeito.Appearance = Appearance.Button;
                pictureBoxLeito.FlatStyle = button1.FlatStyle;
                pictureBoxLeito.FlatAppearance.MouseOverBackColor = button1.FlatAppearance.MouseOverBackColor;
                pictureBoxLeito.FlatAppearance.BorderSize = button1.FlatAppearance.BorderSize;
                pictureBoxLeito.FlatAppearance.CheckedBackColor = Color.Silver;
                pictureBoxLeito.Size = new Size(165, 134);
                pictureBoxLeito.Margin = new Padding(20);
                pictureBoxLeito.Cursor = Cursors.Hand;


                if ((bool)l.IsDisponibilidade)
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoEnable;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito Disponivel");
                }
                else
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoOcupado;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    pictureBoxLeito.Click += DesassociarLeitoPaciente;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito ocupado\nPaciente: {l.Nome}");
                }

                if (l.IsManutencao)
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoManutencao;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito em Manutenção");
                }

                flowLayoutPanelImgLeito.Controls.Add(pictureBoxLeito);
            });

        }


        private void DesassociarLeitoPaciente(object sender, EventArgs e)
        {
            var senderRadio = (RadioButton)sender;
            var obj = (Leito)senderRadio.Tag;
            if (obj.IsManutencao)
                return;

            obj = leitos.FirstOrDefault(p => p.Prontuario == obj.Prontuario);

            string msg = $"Tem certeza que deseja liberar o Leito {obj.NomeLeito}\nocupado pelo paciente {obj.Nome}?";
            if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sessao.Dinamico = obj;
                Frm.FrmJustificativaLeito frm = new Frm.FrmJustificativaLeito(leitos);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AlteracaoLeitoPaciente alteracaoLeitoPaciente = (AlteracaoLeitoPaciente)Sessao.Dinamico;

                    if (
                        (
                            StatusInternacao.Alta
                            | StatusInternacao.Obito 
                            | StatusInternacao.TransferenciaExterna 
                            | StatusInternacao.AguardandoLeito
                         )
                        .HasFlag(alteracaoLeitoPaciente.IdStatusAlteracao)
                        )
                        new PacientePresenter().statuInternacao(new StatusInernacaoPaciente() { Prontuario = obj.Prontuario, IdLeito = obj.Id, Status = alteracaoLeitoPaciente.IdStatusAlteracao });
                    
                    presenterLeito.GetListLeitos();
                    AtualizaUserControls();
                    FindForm().BringToFront();
                }

                obj = null;
            }
        }

        private void AtualizaUserControls()
        {
            SplitterPanel split = Parent.Parent.Parent.Parent.Controls.OfType<SplitterPanel>().LastOrDefault();
            UI005ListaPaciente uC = (UI005ListaPaciente)split.Controls[0];
            uC.Carregar();
            leitos = presenterLeito.GetListLeitos();
            PopulaOcupacoes();
        }

        private void comboBoxPesquisaQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quarto item = (Quarto)comboBoxPesquisaQuarto.SelectedItem;
            PopulaOcupacoes(item.Id);
        }

        private void UI004FrmPanelOcupacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.mySalvar.Click -= MySalvar_Click;
        }
    }
}
