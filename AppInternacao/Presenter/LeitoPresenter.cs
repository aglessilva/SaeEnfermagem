using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;

namespace AppInternacao.Presenter
{
    public class LeitoPresenter
    {
        private readonly ILeito view;
        private Leito leito = null;
        private CRUD crud = null;
        private LISTAOBJETOS objeto = null;

        public LeitoPresenter(ILeito _view)
        {
            view = _view;

            leito = new Leito()
            {
                IsDisponibilidade = _view.Leito.IsDisponibilidade,
                Id = _view.Leito.Id,
                IdQuarto = _view.Leito.IdQuarto,
                NomeLeito = _view.Leito.NomeLeito
            };
        }



        public int? Salvar()
        {
            int? ret = null;
            try
            {
                crud = new CRUD();
                objeto = new LISTAOBJETOS();
                ret = crud.Executar(leito, Procedure.SP_ADD_UPD_LEITO, Acao.Inserir);
                Carregar();
            }
            catch (Exception exS)
            {
                throw exS;
            }

            return ret;
        }

        public int? Excluir()
        {
            int? ret = 0;
            try
            {
                objeto = new LISTAOBJETOS();
                crud = new CRUD();
                ret = crud.Executar(new Leito() { Id = leito.Id }, Procedure.SP_DEL_LEITO, Acao.Excluir);
                Carregar();

                if (ret.HasValue)
                    ret = 2; // 2 é Codigo de exclusão de registro
            }
            catch (Exception exEx)
            {
                throw exEx;
            }

            return ret;
        }

        public void Carregar(Leito Obj = null)
        {
            try
            {
                if (null == Obj)
                    Obj = new Leito();

                objeto = new LISTAOBJETOS();
                view.leitos = objeto.ListaGenerica(Procedure.SP_GET_LEITO, Obj );
                view.Quartos = objeto.ListaGenerica(Procedure.SP_GET_QUARTOS,new Quarto());
            }
            catch (Exception exC)
            {
                throw exC;
            }
        }
    }
}
