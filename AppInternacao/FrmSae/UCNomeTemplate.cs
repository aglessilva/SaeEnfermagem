using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCNomeTemplate : UserControl, ITemplateName
    {
        private TemplateNamePresenter templateNamePresenter = null;
        public UCNomeTemplate()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewNomeTemplate.AutoGenerateColumns = false;
        }

        private void UCNomeTemplate_Load(object sender, EventArgs e)
        {
            FrmMain.mySalvar.Click += Salvar;
            FrmMain.myNovo.Click += Novo;
            templateNamePresenter = new TemplateNamePresenter(this);
            templateNamePresenter.Iniciar();
        }
        
        public List<EstruturaFisica> estruturaFisicas
        {
            set
            {
                List<EstruturaFisica> estruturas = value;
                estruturas.Insert(0, new EstruturaFisica() { Id = 0, Nome = "Selecione" });
                comboBoxEstruturaFisica.DataSource = estruturas;
            }
        }

        public TemplateName templateName
        {
            get => 
                new TemplateName()
                {
                     Id = string.IsNullOrWhiteSpace(textBoxId.Text) ? 0 : Convert.ToInt32(textBoxId.Text),
                     IdUsuario = Sessao.Usuario.Id,
                     IdEstruturaFisica = Convert.ToInt32(comboBoxEstruturaFisica.SelectedValue),
                     Nome = textBoxNomeTemplate.Text.Trim(),
                     Ativo = chkAtivarTemplate.Checked
                };
            set
            {
                textBoxId.Text = value.Id.ToString();
                textBoxNomeTemplate.Text = value.Nome;
                comboBoxEstruturaFisica.Enabled = value.CountExame.Value == 0;
                chkAtivarTemplate.Enabled = value.CountExame.Value >= 1;
                lblAviso.Visible = !comboBoxEstruturaFisica.Enabled;
                comboBoxEstruturaFisica.SelectedValue = value.IdEstruturaFisica;
                chkAtivarTemplate.Checked = value.Ativo ?? false;
            }
        }

        public List<TemplateName> templates
        {
            set
            {
                dataGridViewNomeTemplate.DataSource = null;
                dataGridViewNomeTemplate.DataSource = value;
            }
        }

        private void Novo(object sender, EventArgs e)
        {
            comboBoxEstruturaFisica.SelectedValue = 0;
            textBoxId.Text = "0";
            textBoxNomeTemplate.Text = string.Empty;
        }

        bool Valida()
        {
            bool retorno = true;

            if (string.IsNullOrWhiteSpace(textBoxNomeTemplate.Text))
            {
                groupBox1.Refresh();
                errorProviderNameTemplate.SetError(textBoxNomeTemplate, "Preencha este campo.");
                errorProviderNameTemplate.SetIconPadding(textBoxNomeTemplate, 3);
                retorno = false;
            }
            else
            {
                if (textBoxNomeTemplate.Text.Length < 11)
                {
                    errorProviderNameTemplate.SetError(textBoxNomeTemplate, "Este campo deve conter pelo menos 10 caracteres.");
                    errorProviderNameTemplate.SetIconPadding(textBoxNomeTemplate, 3);
                }
                else
                    errorProviderNameTemplate.SetError(textBoxNomeTemplate, null);
            }

            if (Convert.ToInt32(comboBoxEstruturaFisica.SelectedValue) == 0)
            {
                errorProviderNameTemplate.SetError(comboBoxEstruturaFisica, "Selecione um item.");
                errorProviderNameTemplate.SetIconPadding(comboBoxEstruturaFisica, 3);
                retorno = false;
            }
            else
                errorProviderNameTemplate.SetError(comboBoxEstruturaFisica, null);

            return retorno;
        }

        public void Salvar(object sender, EventArgs e)
        {
            try
            {
                if(Valida())
                {
                    FrmMain.Alert(templateNamePresenter.Salvar());
                    Novo(null, null);
                }
            }
            catch (Exception exSalvar)
            {
                FrmMain.Alert(0,exSalvar);
            }
        }

        private void dataGridViewNomeTemplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var sendGrid = (DataGridView)sender;
                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    templateName = (TemplateName)sendGrid.Rows[e.RowIndex].DataBoundItem;
                }
            }

            if (e.ColumnIndex == 4)
            {
                var sendGrid = (DataGridView)sender;
                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    templateName = (TemplateName)sendGrid.Rows[e.RowIndex].DataBoundItem;
                    SplitContainer ctrl = (SplitContainer)Parent.Parent;
                    ctrl.Panel1.Controls.Add(new UCTemplateItemExameFisico(templateName));
                    Dispose();
                }
            }
        }

        private void chkAtivarTemplate_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAtivarTemplate.Checked)
                chkAtivarTemplate.Text = "Desativar Template";
            else
                chkAtivarTemplate.Text = "Ativar Template";
        }
    }
}
