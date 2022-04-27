using AppInternacao.Enum;
using AppInternacao.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace AppInternacao.Presenter
{
    public class PresenterGeneric
    {
        private CRUD crud = null;
        public PresenterGeneric()
        {
            crud = new CRUD();
        }

        public int Salvar<T>(T obj, Procedure procedure, Acao act = Acao.Inserir)
        {
            int? ret = null;
            try
            {
                ret = crud.Executar(obj, procedure, act);
            }
            catch (Exception exS)
            {
                throw exS;
            }

            return ret ?? 0;
        }

        public int InsertPrescricao(PrescricaoMedica obj)
        {
            int? ret = null;
            try
            {
                ret = crud.InsertPrescricao(obj);
            }
            catch (Exception exS)
            {
                throw exS;
            }

            return ret ?? 0;
        }

        public List<T> GetLista<T>(T obj, Procedure procedure)
        {
            try
            {
                return crud.ListaGenerica<T>(procedure, obj);
            }
            catch (Exception exS)
            {
                throw exS;
            }

        }

        public T GetItem<T>(T obj, Procedure procedure)
        {
            try
            {
                return crud.RetornaObjeto<T>(procedure, obj);
            }
            catch (Exception exS)
            {
                throw exS;
            }

        }

        public int InsertCiclo(DataTable dataTable)
        {
            int? ret = null;
            try
            {
                ret = crud.BulkInsert(dataTable, "TB_CicloPrescricao");
            }
            catch (Exception exCliclo)
            {
                throw exCliclo;
            }

            return ret ?? 0;
        }
    }
}
