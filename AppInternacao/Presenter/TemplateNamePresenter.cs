using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;

namespace AppInternacao.Presenter
{
    public class TemplateNamePresenter
    {
        private CRUD crud = null;
        private readonly ITemplateName view =  null;

        public TemplateNamePresenter(ITemplateName _view){ view = _view; }
        public TemplateNamePresenter(){}

        public void Iniciar()
        {
            try
            {
                crud = new CRUD();
                view.estruturaFisicas = crud.ListaGenerica(Procedure.SP_GET_ESTRUTURA_FISICA, new EstruturaFisica());
                view.templates = crud.ListaGenerica(Procedure.SP_GET_TEMPLATE_NAME, new TemplateName());
            } 
            catch (Exception exExtr)
            {
                throw exExtr;
            }
        }

        public int Salvar()
        {
            int ret = 0;
            try
            {
                crud = new CRUD();
                ret = (int)crud.Executar(view.templateName, Procedure.SP_ADD_UPDT_TEMPLATE_NAME, Acao.Inserir);
                view.templates = crud.ListaGenerica(Procedure.SP_GET_TEMPLATE_NAME, new TemplateName());
            }
            catch (Exception exSalvar)
            {
                throw exSalvar;
            }

            return ret;
        }
    }
}
