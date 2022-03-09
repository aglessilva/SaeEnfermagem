using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Vip.Printer;
using Vip.Printer.Enums;

namespace AppInternacao.FrmSae
{
    public partial class FrmPaciente :UI000FrmTemplate, IPaciente
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        PacientePresenter PacientePresenter = null;
        private Paciente objPeciente = null;
        byte[] _criptyPicture = null;

        public Paciente paciente
        {
            get => new Paciente()
            {
                Id = string.IsNullOrWhiteSpace(textBoxIdPaciente.Text) ? 0 : Convert.ToInt32(textBoxIdPaciente.Text),
                Idade = string.IsNullOrWhiteSpace(textBoxIdade.Text) ? 0 : Convert.ToInt32(textBoxIdade.Text),
                Prontuario = string.IsNullOrWhiteSpace(textProntuario.Text) ? 0 : Convert.ToInt64(textProntuario.Text),
                Sexo = radioButton1.Checked ? 'M' : 'F',
                Nome = textBoxPaciente.Text,
                Foto = _criptyPicture,
                IdEstruturaFisica = Convert.ToInt32(comboBoxEstruturaFisica.SelectedValue),
                Telefone = Regex.Replace(textTelefone.Text, "[^0-9$]", string.Empty),
                Bairro = textBairro.Text,
                Cep = textCep.Text,
                Logradouro = textLogradouro.Text,
                Complemento = textComplemento.Text,
                Localidade = textCidade.Text,
                Uf = textUf.Text,
                Numero = textNumero.Text,
                Status = objPeciente.Status
            };
            set
            {
                if(value.Telefone?.Length < 11)
                    textTelefone.Mask = "(99) 0000-0000#";
                else
                    textTelefone.Mask = "(99) 00000-0000";

                textBoxIdPaciente.Text = value.Id.ToString();
                textBoxPaciente.Text = value.Nome;
                textBoxIdade.Text = value.Idade.ToString();
                textBoxLeito.Text = value.NomeLeito;
                textBoxLeitoCracha.Text = value.NomeLeito;
                textBoxQuarto.Text = value.NomeQuarto;
                textBoxSetor.Text = value.NomeSetor;
                textTelefone.Text = value.Telefone;
                textUf.Text = value.Uf;
                textBairro.Text = value.Bairro;
                textCep.Text = value.Cep;
                textComplemento.Text = value.Complemento;
                textCidade.Text = value.Localidade;
                textLogradouro.Text = value.Logradouro;
                textNumero.Text = value.Numero;
                textBoxProntuarioCracha.Text = textProntuario.Text = value.Prontuario.ToString();
                comboBoxEstruturaFisica.SelectedValue = value.IdEstruturaFisica;
                textBoxDataCracha.Text = value.Data.HasValue? value.Data.Value.ToShortDateString() : textBoxDataCracha.Text;
                GeraProntuario();
                if (value.Foto != null)
                {
                    MemoryStream ms = new MemoryStream(value.Foto);
                    pictureBoxImgCracha.Image = Image.FromStream(ms);
                    _criptyPicture = value.Foto;
                }
                else
                {
                    _criptyPicture = null;
                    pictureBoxImgCracha.Image = Properties.Resources.user0;
                }
                if (Convert.ToChar(value.Sexo).Equals('M'))
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
        }

        public List<Paciente> pacientes { set => dataGridViewPaciente.DataSource = value; }

        public List<EstruturaFisica> estruturaFisicas
        {
            set
            {
                List<EstruturaFisica> estruturas = value;
                estruturas.Insert(0, new EstruturaFisica() { Id = 0, Nome = "Selecione" });
                comboBoxEstruturaFisica.DataSource = estruturas;
            }
        }

        private bool validaCampos()
        {
            TextBox[] textBoxesIgnore = { textBoxLeito, textBoxQuarto, textBoxSetor, textComplemento };
            try
            {
                var lista = groupBox1.Controls.OfType<TextBox>().Where(t => t is TextBox).ToList();

                lista.RemoveAll(t => !t.Enabled || textBoxesIgnore.Contains(t));

                foreach (TextBox item in lista)
                {
                    if (textBoxesIgnore.Any(txt => txt == item))
                        continue;

                    if (string.IsNullOrEmpty(item.Text) || item.Text.Equals("0"))
                    {
                        errorProvider1.SetError(item, "preencha este campo");
                        errorProvider1.SetIconPadding(item, 3);
                    }
                    else
                        errorProvider1.SetError(item, null);
                }

                if (groupBox1.Controls.OfType<RadioButton>().Where(t => t is RadioButton).ToList().Count(c => c.Checked) == 0)
                {
                    // radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProvider1.SetError(radioButton1, "checar o genero");
                    errorProvider1.SetIconPadding(radioButton1, 3);
                    return false;
                }
                else
                {
                    // radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProvider1.SetError(radioButton1, null);
                }

                if (comboBoxEstruturaFisica.SelectedIndex == 0)
                {
                    errorProvider1.SetError(comboBoxEstruturaFisica, "Selecione um item.");
                    errorProvider1.SetIconPadding(comboBoxEstruturaFisica, 3);
                    return false;
                }
                else
                    errorProvider1.SetError(comboBoxEstruturaFisica, null);


                if(string.IsNullOrWhiteSpace(Regex.Replace(textTelefone.Text, "[^0-9$]", string.Empty)))
                {
                    errorProvider1.SetError(textTelefone, "preencha este campo");
                    errorProvider1.SetIconPadding(textTelefone, 3);
                }
                else
                    errorProvider1.SetError(textTelefone, null);

                return lista.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Text) && !x.Text.Equals("0"));
            }
            catch (Exception exErro)
            {
                FrmMain.Alert(0, exErro);
                return false;
            }
        }

        void GeraProntuario()
        {
            if (paciente.Id == 0)
            {
                string barcode = $"{DateTime.Now.Second}{Regex.Replace(Guid.NewGuid().ToString() + DateTime.Now.ToString(), @"[^0-9$]", "")}";
                textProntuario.Text = barcode.PadLeft(12, '0').Substring(0, 12);
            }
            Zen.Barcode.Code128BarcodeDraw code128Barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pbBarcodeCracha.Image = code128Barcode.Draw(textProntuario.Text, 12);
            textBoxProntuarioCracha.Text = textProntuario.Text;
        }

        public void Salvar(object sender, EventArgs e)
        {
            try
            {
                if (validaCampos())
                {
                    if (paciente.Id == 0)
                        GeraProntuario();
                    PacientePresenter = new PacientePresenter(this);

                    if (paciente.Id == 0)
                    {
                        ImprimirCarcha();
                    }
                    if (PacientePresenter.Salvar() == 1)
                        FrmMain.Alert(Alerts.InsertSuccess);

                    MyNovo_Click(null, null);
                }

            }
            catch (Exception exsalvar)
            {
                FrmMain.Alert(exception:exsalvar);
            }

        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            dataGridViewPaciente.RowEnter -= dataGridViewPaciente_RowEnter;
            FrmMain.mySalvar.Visible = FrmMain.myNovo.Visible = FrmMain.myImprimir.Visible = true;
            FrmMain.mySalvar.Click += new EventHandler(Salvar);
            FrmMain.myNovo.Click += MyNovo_Click;
            FrmMain.myImprimir.Click += MyImprimir_Click;

            textBoxDataCracha.Text = DateTime.Now.ToShortDateString();
            textBoxCliente.Text = Sessao.Cliente;

            new ToolTip() { IsBalloon = true, UseAnimation = true }.SetToolTip(buttonLimpar, "Limpar pesquisa.");
            dataGridViewPaciente.AutoGenerateColumns = false;

            PacientePresenter = new PacientePresenter(this);
            PacientePresenter.Carregar();
            textBoxPaciente.Focus();
            dataGridViewPaciente.RowEnter += dataGridViewPaciente_RowEnter;
          
        }

        private void MyImprimir_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                var printer = new Printer("POS-58", PrinterType.Epson, Encoding.GetEncoding(28591));
                string dadosPaci = $"Nome:{objPeciente.Nome}\nIdade:{objPeciente.Idade}\nLeito:{objPeciente.NomeLeito}\nData:{textBoxDataCracha.Text}";
                //Image image = Properties.Resources.HP;
                //printer.Image(image);
                printer.AlignCenter();
                printer.NormalWidth();
                printer.WriteLine("HOSPITAL CENTRAL DE GUAIANAZES");
                printer.WriteLine("H-C-G");
                printer.Separator();
                printer.AlignLeft();
                printer.WriteLine(dadosPaci);
                printer.AlignCenter();
                printer.Code128(objPeciente.Prontuario.ToString());
                printer.WriteLine(objPeciente.Prontuario.ToString());
                printer.NewLines(3);

                printer.PartialPaperCut();
                printer.PrintDocument();
            }

        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            FrmMain.myImprimir.Enabled = false;
            FrmMain.mySalvar.Enabled = true;

            TextBox[] textBoxesIgnore = { textBoxLeito, textBoxQuarto, textBoxSetor };

            var lista = groupBox1.Controls.OfType<TextBox>().Where(t => t is TextBox).ToList();

            lista.RemoveAll(t => !t.Enabled || textBoxesIgnore.Contains(t));

            foreach (TextBox item in lista)
            {
                if (textBoxesIgnore.Any(txt => txt == item))
                    continue;
                errorProvider1.SetError(item, null);
            }

            
            errorProvider1.SetError(textTelefone, null);
            errorProvider1.SetError(comboBoxEstruturaFisica, null);
            errorProvider1.SetError(radioButton1, null);

            paciente = new Paciente();
            pbBarcodeCracha.Image = Properties.Resources.barcode;
            dataGridViewPaciente.ClearSelection();
            textTelefone.Text  = textProntuario.Text = textBoxProntuarioCracha.Text = textBoxDataCracha.Text = string.Empty;
        }

        private void textBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && !e.KeyChar.ToString().Equals("\b"))
                e.Handled = true;
        }

        private void textBoxPaciente_TextChanged(object sender, EventArgs e)
        {
            textBoxNomeCrachar.Text = textBoxPaciente.Text;
        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {
            textBoxIdadeCracha.Text = textBoxIdade.Text;
        }

        private void dataGridViewPaciente_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                foreach (DataGridViewRow row in senderGrid.Rows)
                {
                    if (row.Index < e.RowIndex)
                        continue;
                    objPeciente = (Paciente)row.DataBoundItem;

                     
                    if (string.IsNullOrWhiteSpace(objPeciente.NomeLeito))
                    {
                        if ((StatusInternacao.Alta | StatusInternacao.Obito).HasFlag(objPeciente.Status))
                        {
                            row.Cells[6].Value = objPeciente.Status == StatusInternacao.Obito ? Properties.Resources.userExit : Properties.Resources.check;
                            row.Cells[6].ToolTipText = $"Paciente liberado\nStatus: Ocorrência de {(objPeciente.Status == StatusInternacao.Alta ? "Alta" : "Óbito")} ";
                        }
                        else
                        {
                            row.Cells[6].Value = Properties.Resources.Error_80_icon_icons_com_57326;
                            row.Cells[6].ToolTipText = "Aguardando liberação de leito";
                        }
                    }
                    else
                        row.Cells[6].ToolTipText = "Paciente Internado";
                }
            }
            catch (Exception exG)
            {
                throw new Exception("Erro ao tentar Listar pacientes: " + exG.Message);
            }
        }

        private void textBoxPesquisaPaciente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaPaciente.Text.Length > 3 && textBoxPesquisaPaciente.Text.Length <= 10)
                {
                    PacientePresenter = new PacientePresenter(this);
                    PacientePresenter.Pesquisar(new Paciente() { Nome = textBoxPesquisaPaciente.Text.Trim() });
                }
                else if (textBoxPesquisaPaciente.Text.Length == 0)
                {
                    PacientePresenter = new PacientePresenter(this);
                    PacientePresenter.Pesquisar(new Paciente());
                }
                else
                    return;
            }
            catch (Exception exPes)
            {
                throw new Exception("Ocorreu um erro na pesquisa\n" + exPes.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaPaciente.Text = string.Empty;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {

            if (_criptyPicture != null)
            {
                _criptyPicture = null;
                pictureBoxImgCracha.Image = Properties.Resources.user0;
            }
            else
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Imagem | *.gif; *.jpeg; *.jpg; *.png;";
                fileDialog.Title = "Selecione uma Foto do paciente";
                DialogResult dialog = fileDialog.ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    _criptyPicture = File.ReadAllBytes(fileDialog.FileName);
                    if (_criptyPicture.LongLength < 3e+6)
                    {
                        MemoryStream ms = new MemoryStream(_criptyPicture);
                        pictureBoxImgCracha.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        _criptyPicture = null;
                        MessageBox.Show("A Imagem ultrapassa o limite de 3Mb.\nSelecione outra imagem menor que 3 MegaByte ou reduza o tamanho da imagem", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        void ImprimirCarcha()
        {
            StringBuilder stringBuilder = new StringBuilder();

            List<string> lstPrint = new List<string> { objPeciente.Nome, $"Idade:{objPeciente.Idade.ToString()}",$"Entrada:{DateTime.Now.ToShortDateString()}", $"Leito:{objPeciente.NomeLeito}", objPeciente.Prontuario.ToString() };
            using (StreamReader stream = new StreamReader(@"..\..\ZplPrint\TemplateEtiquetaZPL.txt"))
            {
                string linha = string.Empty;
                int i = 0;
                while(!stream.EndOfStream)
                {
                    linha = stream.ReadLine();
                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    if(linha.Split(' ').Any(s => s.Contains("{#}")))
                    {
                        linha = linha.Replace("{#}", lstPrint[i++]);
                    }
                    stringBuilder.AppendLine(linha);
                }
            }

            NetworkStream ns = null;
            Socket socket = null;
            EndPoint printerIP = null;
            try
            {
                if (printerIP == null)
                {
                    /*IP is a string property for the printer's IP address. */
                    /*6101 is the common port of all our Zebra printers. */
                    printerIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9100);
                  //  printerIP = new IPEndPoint(IPAddress.Parse("192.168.1.100"),9100 );
                }

                socket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);
                socket.Connect(printerIP);

                ns = new NetworkStream(socket);

                byte[] toSend = Encoding.ASCII.GetBytes(stringBuilder.ToString());
                ns.Write(toSend, 0, toSend.Length);
            }
            finally
            {
                if (ns != null)
                    ns.Close();

                if (socket != null && socket.Connected)
                    socket.Close();
            }


        }

        private void textCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
                return;
            }

        }

        private void textCep_KeyUp(object sender, KeyEventArgs e)
        {

            if (textCep.Text.Length < 8)
                return;

            try
            {
                this.Enabled = !this.Enabled;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{textCep.Text}/json/");
                request.ServerCertificateValidationCallback = delegate { return true; };
                request.AllowAutoRedirect = false;

                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return; // Sai da rotina
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(response);
                            if (!string.IsNullOrEmpty(endereco.Cep))
                            {
                                textBairro.Text = endereco.Bairro;
                                textCep.Text = endereco.Cep.ToString();
                                textLogradouro.Text = endereco.Logradouro;
                                textComplemento.Text = endereco.Complemento;
                                textCidade.Text = endereco.Localidade;
                                textUf.Text = endereco.Uf.ToString();
                                this.Enabled = !this.Enabled;
                                textNumero.Focus();
                            }
                            else
                            {
                                MessageBox.Show($"Cep {textCep.Text} não encontratdo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Enabled = !this.Enabled;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Enabled = !this.Enabled;
                throw ex;
            }
        }

        private void dataGridViewPaciente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var sendGrid = (DataGridView)sender;
            objPeciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;
            
            FrmMain.mySalvar.Enabled = !(StatusInternacao.Alta | StatusInternacao.Obito).HasFlag(objPeciente.Status) && Sessao.Usuario.Perfil != Enum.Perfil.Tecnico;

            paciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;
            FrmMain.myImprimir.Enabled = !(StatusInternacao.Alta | StatusInternacao.Obito).HasFlag(objPeciente.Status);

        }

        private void FrmPaciente002_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.mySalvar.Click -= Salvar;
            FrmMain.myNovo.Click -= MyNovo_Click;
        }

        private void textTelefone_Leave(object sender, EventArgs e)
        {
            string numberFone = Regex.Replace(textTelefone.Text, "[^0-9$]", string.Empty);
            if (numberFone.Length < 11)
            {
                textTelefone.Mask = "(99) 0000-0000";
                textTelefone.Text = numberFone;
            }
        }
    }
}
