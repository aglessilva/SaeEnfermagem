using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;

namespace AppInternacao.Presenter
{
    public class HistoricoEnfermagemPresenter
    {
        CRUD crud = null;
        private HistoricoEnfermagem historicoEnfermagem;
        private readonly IHistoricoEnfermagem view;
        public HistoricoEnfermagemPresenter(IHistoricoEnfermagem _view)
        {
            view = _view;
        }

        public int? Salvar()
        {
            try
            {
                crud = new CRUD();
                historicoEnfermagem = view.HistoricoEnfermagem;
                Procedure p = Procedure.SP_ADD_HISTORICO_ENFERMAGEM;
                return crud.Executar(historicoEnfermagem, p, Acao.Inserir);
            }
            catch (Exception exSalvar)
            {
                throw new Exception("Erro ao tentar salvar Historico de enfermagem\n" + exSalvar.Message);
            }
        }
    }
}
