﻿using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;
using System.Collections.Generic;

namespace AppInternacao.Presenter
{
    public class PacientePresenter
    {
        Paciente paciente = null;
        private readonly IPaciente view;
        CRUD crud = null;

        public PacientePresenter(IPaciente _view)
        {
            view = _view;
        }

        public PacientePresenter(){}

        public int Salvar(Paciente _paciente =  null)
        {
            int? ret = 0;
            try
            {
                if (_paciente == null)
                    paciente = view.paciente;
                else
                    paciente = _paciente;

                crud = new CRUD();
                ret = crud.Executar(paciente, Procedure.SP_ADD_UPDT_PACIENTE, Acao.Inserir);
                if (ret > 1)
                    ret = 1;
                // apos o inserte, recarregar o gride
                if (_paciente == null)
                    Carregar(loadEstrutura: false);

            }
            catch (Exception exeS)
            {
                throw exeS;
            }

            return ret?? 0;
        }


        public int BaixarPaciente(BaixarPaciente obj)
        {
            int? ret = 0;
            try
            {
                crud = new CRUD();
                ret = crud.Executar(new BaixarPaciente() { Prontuario = obj.Prontuario, IdLeito = obj.IdLeito }, Procedure.SP_BAIXAR_PACIENTE, Acao.Inserir);
                if (ret > 1)
                    ret = 1;
            }
            catch (Exception exeS)
            {
                throw exeS;
            }

            return ret ?? 0;
        }


        public void Carregar(Paciente obj = null, bool loadEstrutura = true)
        {
            try
            {
                if (null == obj)
                    obj = new Paciente();

                crud = new CRUD();
                view.pacientes =  crud.ListaGenerica(Procedure.SP_GET_PACIENTE, obj);
                if (loadEstrutura)
                    view.estruturaFisicas = crud.ListaGenerica(Procedure.SP_GET_ESTRUTURA_FISICA, new EstruturaFisica());
            }
            catch (Exception exC)
            {
                throw exC;
            }
        }

        public List<Paciente> GetPacientes(Paciente obj = null)
        {
            try
            {
                if (null == obj)
                    obj = new Paciente();

                crud = new CRUD();
                return crud.ListaGenerica(Procedure.SP_GET_PACIENTE, obj);
            }
            catch (Exception exC)
            {
                throw exC;
            }
        }

        public void Pesquisar(Paciente obj)
        {
            try
            {
                if (null == obj)
                    obj = new Paciente();

                crud = new CRUD();
                view.pacientes = crud.ListaGenerica(Procedure.SP_GET_PACIENTE, obj);
            }
            catch (Exception exPesquisa)
            {
                throw exPesquisa;
            }
        }


        /// <summary>
        /// Carrega a Sessao com os dados do Paciente
        /// </summary>
        /// <param name="_numeroProntuario"> informe o número de prontuário do paciente</param>
        public void SessaoPaciente(long _numeroProntuario)
        {
            try
            {
                Sessao.Paciente = null;
                crud = new CRUD();
                Sessao.Paciente = crud.RetornaObjeto(Procedure.SP_GET_PACIENTE, new Paciente() { Prontuario = _numeroProntuario });
            }
            catch (Exception exC)
            {
                throw new Exception("Erro ão tentar carregar sessaõ do Usuarios: " + exC.Message);
            }

        }


    }
}
