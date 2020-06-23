using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppInternacao.Presenter;
using AppInternacao.Model;

namespace AppInternacao.FrmSae
{
    public partial class UC01ListaHistoricoEnfermagem : UserControl
    {
        HistoricoEnfermagemPresenter HistoricoEnfermagemPresenter = null;
        HistoricoEnfermagem historico = null;

        public UC01ListaHistoricoEnfermagem()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewHistoricoEnfermagem.AutoGenerateColumns = false;
        }

        private void UC01ListaHistoricoEnfermagem_Load(object sender, EventArgs e)
        {
            HistoricoEnfermagemPresenter = new HistoricoEnfermagemPresenter();
            dataGridViewHistoricoEnfermagem.DataSource = HistoricoEnfermagemPresenter.Lista();
        }

        private void dataGridViewHistoricoEnfermagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    var ctrl = ParentForm.Controls[0].Controls[0].Controls[0].Controls[0].Controls[0].Controls[0];
                    RichTextBoxEx.RichTextBoxEx richTextBox = (RichTextBoxEx.RichTextBoxEx)ctrl.Controls[0];
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        historico = (HistoricoEnfermagem)dataGridViewHistoricoEnfermagem.Rows[e.RowIndex].DataBoundItem;
                        richTextBox.Rtf = historico.Historico;
                        if (sendGrid.Rows.GetLastRow(DataGridViewElementStates.Visible) > e.RowIndex)
                            richTextBox.Tag = "notValidate";
                        else
                            richTextBox.Tag = string.Empty;
                    }
                }
            }
            catch (Exception exGrid)
            {
                MessageBox.Show("Erro na visualização de histórico de Enfermagem\n" + exGrid.Message);
            }
        }
    }
}
