using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System.Data;
using System;

namespace AppInternacao.Presenter
{
    public class TemplateExamePresenter
    {
        CRUD crud = null;
        private readonly IArea_Itens view = null;

        public TemplateExamePresenter(IArea_Itens _view){ view = _view;}
        public TemplateExamePresenter(){}
        public void GetAreaItens()
        {
            try
            {
                crud = new CRUD();
                view.area_Itens = crud.ListaGenerica(Procedure.SP_GET_AREAS_ITENS, new Area_Itens());
            }
            catch (Exception exExtr)
            {
                throw exExtr;
            }
        }


        public int BulkInsert(DataTable dataTable, string sqlTabela)
        {
            try
            {
                dataTable.Columns.RemoveAt(5);
                crud = new CRUD();
                return (int)crud.BulkInsert(dataTable, sqlTabela);
            }
            catch (Exception exBulk)
            {
                throw exBulk; 
            }
        }
    }
}
