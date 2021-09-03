using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AppInternacao.Presenter
{
    public class QuartoPresenter
    {
        readonly IQuarto view;
        Quarto quarto = null;
        private CRUD crud = null;
        private LISTAOBJETOS objeto = null;

        public QuartoPresenter(IQuarto _view)
        {
            view = _view;
            quarto = _view.Quarto;
        }

        public int? Salvar()
        {
            int? ret = null;
            try
            {
                crud = new CRUD();
                objeto = new LISTAOBJETOS();

                if (quarto.Id == 0)
                    ret = crud.Executar(new Quarto() { NomeQuarto = quarto.NomeQuarto }, Procedure.SP_VALIDA_QUANRTO, Acao.Verificar);

                if (!ret.HasValue)
                {
                    ret = crud.Executar(quarto, Procedure.SP_ADD_UPD_QUARTO, Acao.Inserir);
                    List<Quarto> quartos = objeto.ListaGenerica(Procedure.SP_GET_QUARTOS, new Quarto());

                    view.Quartos = quartos;
                }
                return ret;
            }
            catch (Exception exSal)
            {
                throw exSal;
            }
        }


        public int? Excluir(int _id)
        {
            int? ret = 0;
            try
            {
                objeto = new LISTAOBJETOS();
                crud = new CRUD();
                ret = crud.Executar(new Quarto() { Id = _id }, Procedure.SP_DEL_QUARTO, Acao.Excluir);
                view.Quartos = objeto.ListaGenerica(Procedure.SP_GET_QUARTOS, new Quarto());

                if (ret.HasValue)
                    ret = 2; // 2 é Codigo de exclusão de registro
            }
            catch (SqlException exSqEx)
            {
                throw exSqEx;
            }
            catch (Exception exEx)
            {
                throw exEx;
            }

            return ret;
        }


        public void Carregar(Quarto objetoQuarto = null)
        {
            try
            {
                if (null == objetoQuarto)
                    objetoQuarto = new Quarto();

                objeto = new LISTAOBJETOS();
                view.Setores = objeto.ListaGenerica(Procedure.SP_GET_SETOR, new Setor());
                view.Quartos = objeto.ListaGenerica(Procedure.SP_GET_QUARTOS_BYNAME, objetoQuarto);
            }
            catch (Exception exC)
            {
                throw exC;
            }
        }

    }
}
