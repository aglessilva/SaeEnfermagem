using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI014FrmExameFisico : UI000FrmTemplate
    {
        public UI014FrmExameFisico()
        {
            InitializeComponent();
        }
        EstruturaFisica estruturaFisica = null;
        private PresenterGeneric presenterGeneric = null;
        List<EstruturaFisica> lstEstrutura = new List<EstruturaFisica>();
        int somaTotalGlasgow = 0;
         TextBox TextBox = null;
        RadioButtonExt radioButtonItem = null;

        List<object> pressaoArterial = new List<object>()
         {
            new {Codigo = 0, Titulo = "Selecione", Valor = "0"},
            new {Codigo = 1, Titulo = "Ótima", Valor = "< 120 X < 80"},
            new {Codigo = 2, Titulo = "Normal", Valor = "120 a 129 X 80 a 84" },
            new {Codigo = 3, Titulo = "Normal Alto",Valor = "130 a 139 X 85 a 89" },
            new {Codigo = 4, Titulo = "Estágio 1", Valor = "140 a 159 X 90 a 99" },
            new {Codigo = 5, Titulo = "Estágio 2", Valor = "160 a 179 X 100 a 109" },
            new {Codigo = 6, Titulo = "Estágio 3", Valor = ">= 180 X >= 110" }
        };

        //void Populatemplate()
        //{
        //    try
        //    {
        //        foreach (Area_Itens item in lstAreaItem)
        //        {
        //            radioButtonItem = new RadioButtonExt() { Value = item.IdItemArea.ToString(), Text = item.Nome, AutoSize = true };
        //            switch (item.IdArea)
        //            {
        //                case Area.SistemaNeurologico:
        //                    {
        //                        if (!gSistemaNeurologico.Visible)
        //                            gSistemaNeurologico.Visible = true;

        //                        flpSistemaNerologico.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.Pupilas:
        //                    {
        //                        if (!gPupilas.Visible)
        //                            gPupilas.Visible = true;

        //                        flpPupilas.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.RegulacaoTermica:
        //                    {
        //                        if (!gRegulacaoTermica.Visible)
        //                            gRegulacaoTermica.Visible = true;

        //                        if (new int[] { 18, 19 }.Any(s => item.IdItemArea.Equals(s)))
        //                        {
        //                            flpRegulacaotermica.Controls.Add(radioButtonItem);
        //                            if (TextBox == null)
        //                                TextBox = new TextBox() { Text = "ºC", Width = 40, TextAlign = HorizontalAlignment.Right };
        //                        }
        //                        else
        //                            flpRegulacaotermica.Controls.Add(radioButtonItem);

        //                        break;
        //                    }
        //                case Area.Oxigenacao:
        //                    {
        //                        if (!gSistemaOxigenacao.Visible)
        //                            gSistemaOxigenacao.Visible = true;

        //                        flpOxigenacao.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.Pele:
        //                    {
        //                        if (!gPele.Visible)
        //                            gPele.Visible = true;

        //                        flpPele.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.SistemaGastrointestinal:
        //                    {
        //                        if (!gSistemaGastroIntestinal.Visible)
        //                            gSistemaGastroIntestinal.Visible = true;

        //                        if (new int[] { 40, 41, 42 }.Any(s => item.IdItemArea.Equals(s)))
        //                        {
        //                            pGavagem.Visible = item.IdItemArea == 40 ? true : false;
        //                            pEvacuacoes.Visible = item.IdItemArea == 41 ? true : false;
        //                            pFlatos.Visible = item.IdItemArea == 42 ? true : false;
        //                        }
        //                        else
        //                            flpSistemaGastroIntestinal.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.SistemaVascular:
        //                    {
        //                        if (!gSistemaVascular.Visible)
        //                            gSistemaVascular.Visible = true;

        //                        flpSistemaVascular.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.SistemaAbdominal:
        //                    {
        //                        if (!gSistemaAbdominal.Visible)
        //                            gSistemaAbdominal.Visible = true;

        //                        flpSistemaAbdominal.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.SistemaUrinario:
        //                    {
        //                        if (!gSistemaUrinario.Visible)
        //                            gSistemaUrinario.Visible = true;

        //                        flpsistemaUrinario.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.LesaoCompressao:
        //                    {
        //                        if (!gLesaoCompressao.Visible)
        //                            gLesaoCompressao.Visible = true;

        //                        flpLesao.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.GloboPinard:
        //                    {
        //                        if (!gPinard.Visible)
        //                            gPinard.Visible = true;

        //                        flpPinard.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.ComaGlasgow:
        //                    {
        //                        if (!gGlasgow.Visible)
        //                            pFormGlasgow.Visible = gGlasgow.Visible = true;
        //                        break;
        //                    }
        //                case Area.ControleCateteres:
        //                    {
        //                        if (!gCateterSonda.Visible)
        //                            gCateterSonda.Visible = true;

        //                        flpCateteres.Controls.Add(radioButtonItem);
        //                        break;
        //                    }
        //                case Area.PressaoArterial:
        //                    {
        //                        if (!gEscalaPressao.Visible)
        //                            gEscalaPressao.Visible = true;

        //                        pPA.Visible = item.IdItemArea == 87 ? true : false;
        //                        break;
        //                    }
        //                default:
        //                    break;
        //            }
        //        }

        //        if (TextBox != null)
        //            flpRegulacaotermica.Controls.Add(TextBox);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
