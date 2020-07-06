using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.View;
using System;

namespace AppInternacao.Presenter
{
    public class LoginPresenter
    {
        private LISTAOBJETOS objeto = null;
        private readonly ILogin view = null;

        public LoginPresenter(ILogin _view)
        {
            view = _view;
        }

        public LoginPresenter(){}

        public Usuario AutenticarUsuario(Usuario usuario = null)
        {
            try
            {
                objeto = new LISTAOBJETOS();
                if (usuario == null)
                    return objeto.RetornaObjeto(Procedure.SP_AUTENTICAR_USUARIO, new Usuario() { Login = view.login.UserName, Senha = view.login.PassWordUser });
                else
                    return objeto.RetornaObjeto(Procedure.SP_AUTENTICAR_USUARIO, new Usuario() { Login = usuario.Login, Cpf = usuario.Cpf });

            }
            catch (Exception exAut)
            {
                throw new Exception("Erro ao tentar autenticar usuario\n" + exAut.Message);
            }
        }


    }
}
