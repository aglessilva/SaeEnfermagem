using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System.Collections.Generic;
using System;

namespace AppInternacao.Presenter
{
    public class HistoricoEnfermagemPresenter
    {
        CRUD crud = null;
        LISTAOBJETOS objeto = null;
        HistoricoEnfermagem historicoEnfermagem = null;
        private readonly IHistoricoEnfermagem view = null;

        public HistoricoEnfermagemPresenter(){}

        public HistoricoEnfermagemPresenter(IHistoricoEnfermagem _view)
        {
            view = _view;
        }

        public int Salvar()
        {
            int? ret = 0;
            try
            {
                crud = new CRUD();
                historicoEnfermagem = view.historicoEnfermagem;
                ret = crud.Executar(historicoEnfermagem, Procedure.SP_ADD_HISTORICO_ENFERMAGEM, Acao.Inserir);
            }
            catch (Exception exCrudHistorico)
            {
                throw exCrudHistorico;
            }

            return ret ?? 0;
        }

        public void GetHistoricoEnfermagem()
        {
            try
            {
                objeto = new LISTAOBJETOS();
                view.historicoEnfermagems = objeto.ListaGenerica(Procedure.SP_GET_HISTORICO_ENFERMAGEM, new HistoricoEnfermagem() { IdPaciente = Sessao.Paciente.Id });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<HistoricoEnfermagem> Lista()
        {
            try
            {
                objeto = new LISTAOBJETOS();
                return objeto.ListaGenerica(Procedure.SP_GET_HISTORICO_ENFERMAGEM, new HistoricoEnfermagem() { IdPaciente = Sessao.Paciente.Id });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
