using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;
using System.Collections.Generic;

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
                NomeLeito = _view.Leito.NomeLeito,
                IsManutencao = view.Leito.IsManutencao,
                Act = 'A'
            };
        }


        public int? Salvar()
        {
            int? ret = null;
            try
            {
                crud = new CRUD();
                ret = crud.Executar(leito, Procedure.SP_ADD_UPD_LEITO, Acao.Inserir);
                Carregar();
            }
            catch (Exception exS)
            {
                throw exS;
            }

            return ret;
        }

        public int? Salvar(Leito leito)
        {
            int? ret = null;
            try
            {
                crud = new CRUD();
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
                crud = new CRUD();
                ret = crud.Executar(new Leito() { Id = leito.Id }, Procedure.SP_DEL_LEITO, Acao.Excluir);

                if (ret == 2 )
                    Carregar();
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
                List<Quarto> lst = objeto.ListaGenerica(Procedure.SP_GET_QUARTOS, new Quarto());
                view.Quartos = lst;
            }
            catch (Exception exC)
            {
                throw exC;
            }
        }
    }
}
