using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;
using System.Collections.Generic;

namespace AppInternacao.Presenter
{

    public class UsuarioPresenter
    {
        CRUD crud = null;
        Usuario usuario = null;
        private readonly IUsuario view = null;

        public UsuarioPresenter(IUsuario _view)
        {
            view = _view;
        }

        public UsuarioPresenter(){}

        public int? Salvar(Usuario _usuario =  null)
        {
            try
            {
                crud = new CRUD();
                if (_usuario == null)
                    usuario = view.usuario;
                else
                    usuario = _usuario;
                Procedure p = usuario == null ? Procedure.SP_UPDT_SENHA_USUARIO : Procedure.SP_ADD_UPDT_USUARIO;
                return crud.Executar(usuario, p, Acao.Inserir);
            }
            catch (Exception exSalvar)
            {
                throw new Exception("Erro ao tentar salvar usuario\n" + exSalvar.Message);
            }
        }

        public List<Usuario> Carregar(Usuario _usuario = null)
        {
            try
            {
                crud = new CRUD();
                if (_usuario == null)
                    _usuario = new Usuario();

                return crud.ListaGenerica(Procedure.SP_GET_USUARIOS, _usuario);
            }
            catch (Exception exGetuser)
            {
                throw exGetuser;
            }
        }
    }
}
