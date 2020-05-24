using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;

namespace AppInternacao.Presenter
{
    public class PresenterMain
    {
        readonly IMain view = null;
        private LISTAOBJETOS objeto = null;
        public PresenterMain(IMain _view)
        {
            view = _view;
        }

        public void Iniciar()
        {
            try
            {
                objeto = new LISTAOBJETOS();
                view.Main = objeto.RetornaObjeto(Procedure.SP_VALIDA_CLIENTE, view.Main);
            }
            catch (Exception ExI)
            {
                throw ExI;
            }
        }
    }
}
