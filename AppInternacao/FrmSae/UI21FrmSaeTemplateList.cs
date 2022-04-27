using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI21FrmSaeTemplateList : AppInternacao.FrmSae.UI000FrmTemplate
    {
        public UI21FrmSaeTemplateList()
        {
            InitializeComponent();
        }
        PresenterGeneric presenterGeneric = null;
        List<TemplateNameExameFisico> lstTemplateNamesExamesFisicos = null;

        List<CheckBoxExt> checkBoxExts = null;

        TemplateNameExameFisico templateNameExameFisico = null;

        private void UI21FrmSaeTemplateList_Load(object sender, EventArgs e)
        {
            try
            {
                FrmMain.mySalvar.Click += MySalvar_Click;

                checkBoxExts = new List<CheckBoxExt> { checkBoxExt1, checkBoxExt2, checkBoxExt3, checkBoxExt4, checkBoxExt5 };

                presenterGeneric = new PresenterGeneric();
                lstTemplateNamesExamesFisicos = presenterGeneric.GetLista(new TemplateNameExameFisico(), Procedure.SP_GET_NAME_EXAME_FISICO);
                lstTemplateNamesExamesFisicos.Insert(0, new TemplateNameExameFisico { Id = 0, NomeTemplate = "Selecione um template de exame físico..." });
                comboBoxTemplateExameFisico.DataSource = lstTemplateNamesExamesFisicos;
                
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void MySalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string _setorAssociado = string.Join(",", checkBoxExts.FindAll(s => s.Checked).Select(t => t.Value));
                FrmMain.Alert(presenterGeneric.Salvar(new { Id = templateNameExameFisico.Id, SetorAssociado = _setorAssociado }, Procedure.SP_UPDT_ASSOCIAR_TEMPLATE_EXAME_FISICO, Acao.Atualizar) == 1 ? Alerts.InsertSuccess : Alerts.ErrorException);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void comboBoxTemplateExameFisico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                templateNameExameFisico = (TemplateNameExameFisico)comboBoxTemplateExameFisico.SelectedItem;
                lblDescricao.Text = templateNameExameFisico.DescricaoTemplate;
                lblDescricao.Visible = FrmMain.mySalvar.Visible = comboBoxTemplateExameFisico.SelectedIndex > 0;

                checkBoxExts.ForEach(c => { c.Checked = false; c.Enabled = true; });

                if (comboBoxTemplateExameFisico.SelectedIndex > 0)
                {
                    checkBoxExts.ForEach(c => 
                    {
                        c.Checked = templateNameExameFisico.SetorAssociado.Contains(c.Value); c.Enabled = true; 
                    });

                    CheckBoxExt checkBox = checkBoxExts.Find(c => c.Value.Equals(templateNameExameFisico.SetorAssociado.Split(',')[0].ToString()));
                    checkBox.Checked = true;
                    checkBox.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }
       
    }
}
