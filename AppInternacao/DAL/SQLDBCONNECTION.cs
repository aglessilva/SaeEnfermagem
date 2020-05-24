using System;
using System.Data.SqlClient;

namespace AppInternacao.Model
{
    public class SQLDBCONNECTION
    {
        #region VARIAVEIS DE AMBIENTE
        private readonly string sTrconn = @"Password=#$Sucesso01;Persist Security Info=True;User ID=sa;Initial Catalog=DB_SAE;Data Source=HAGLESPW701\SQLEXPRESS";
        private SqlConnection cnn = null;
        #endregion

        #region METODOS DE CONEXAO COM O BANCO
        public SQLDBCONNECTION() { }

        protected SqlConnection DBCONN(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection == null)
                {
                    cnn = new SqlConnection(this.sTrconn);
                    cnn.Open();
                }
                else
                {
                    cmd.Connection.Dispose();
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexao com o banco: " + ex.Message);
            }
            return cnn;
        }
        #endregion
    }
}
