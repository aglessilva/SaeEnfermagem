using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;


namespace AppInternacao.Presenter
{

    public class UsuarioPresenter
    {
        CRUD crud = null;
        LISTAOBJETOS objeto = null;
        Usuario usuario = null;
        private readonly IUsuario view = null;

        public UsuarioPresenter(IUsuario _view)
        {
            view = _view;
        }

        public int? Salvar()
        {
            try
            {
                crud = new CRUD();
                usuario = view.usuario;
                return crud.Executar(usuario, Procedure.SP_ADD_USUARIO, Acao.Inserir);
            }
            catch (Exception exSalvar)
            {
                throw new Exception("Erro ao tentar salvar usuario\n" + exSalvar.Message);
            }
        }
      
    }
}
