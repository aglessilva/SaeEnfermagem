using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInternacao.Enum;

namespace AppInternacao.Model
{
    public class DBConn
    {
       
      //  const string cnn = @"Password=#$Sucesso01;Persist Security Info=True;User ID=sa;Initial Catalog=DB_SAE;Data Source=HAGLESPW701\SQLEXPRESS";
        const string cnn = @"Provider=SQLOLEDB.1;Password=#$Sucesso01;Persist Security Info=True;User ID=sa;Initial Catalog=DB_SAE;Data Source=.";


        public SqlCommand GetSqlCommand(Enum.Procedure procedure)
        {
            SqlCommand command = null;
            try
            {
                command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = new SqlConnection(cnn);
                command.CommandText = procedure.ToString();
                command.CommandTimeout = 0;
                command.Connection.Open();
            }
            catch (Exception excnn)
            {
                command.Connection.Dispose();
                command.Connection.Close();

                throw new Exception("Erro de conexão: " + excnn.Message);
            }

            return command;
        }



        public int Salvar(Paciente paciente)
        {
            int ret = 0;
            SqlCommand sqlCommand = null;
            try
            {
                sqlCommand = GetSqlCommand(Enum.Procedure.SP_ADD_UPDT_PACIENTE);

                sqlCommand.Parameters.Add(new SqlParameter("@PRONTUARIO", paciente.Prontuario));
                sqlCommand.Parameters.Add(new SqlParameter("@ID", paciente.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@IDCLIENTE", Sessao.CodigoCliente));
                sqlCommand.Parameters.Add(new SqlParameter("@NOME", paciente.Nome));
                sqlCommand.Parameters.Add(new SqlParameter("@SEXO", paciente.Sexo));
                sqlCommand.Parameters.Add(new SqlParameter("@IDADE", paciente.Idade));

                ret = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                sqlCommand.Connection.Dispose();
                sqlCommand.Connection.Close();
                throw;
            }

            return ret;
        }
        

        public void ValidaCliente()
        {
            try
            {
                SqlCommand sqlCommand = null;

                sqlCommand = GetSqlCommand(Enum.Procedure.SP_VALIDA_CLIENTE);
                sqlCommand.Parameters.Add(new SqlParameter("@DOMINIO", Sessao.Dominio));

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Sessao.CodigoCliente = Convert.ToInt32(dr[0].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Paciente> GetPacientes(string _parametro)
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente = null;

            try
            {
                SqlCommand sqlCommand = null;

                sqlCommand = GetSqlCommand(Enum.Procedure.SP_GET_PACIENTE);
                sqlCommand.Parameters.Add(new SqlParameter("@PARAMETRO", _parametro));
                sqlCommand.Parameters.Add(new SqlParameter("@IDCLIENTE", Sessao.CodigoCliente));

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    paciente = new Paciente()
                    {
                         Id = Convert.ToInt32(dr[0].ToString()),
                         Nome = dr[1].ToString(),
                         Prontuario = Convert.ToInt64(dr[2].ToString()),
                        // Sexo = Convert.ToChar(dr[3].ToString()),
                        // Leito = dr[4].ToString(),
                        // Idade = Convert.ToInt32(dr[5].ToString()),
                    };

                    pacientes.Add(paciente);
                }


                return pacientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paciente GetPaciente(string _parametro)
        {
            Paciente paciente = null;

            try
            {
                SqlCommand sqlCommand = null;

                sqlCommand = GetSqlCommand(Enum.Procedure.SP_GET_PACIENTE_DIAGNOSTICO);
                sqlCommand.Parameters.Add(new SqlParameter("@PARAMETRO", _parametro));

                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    paciente = new Paciente()
                    {
                        Id = Convert.ToInt32(dr[0].ToString()),
                        Prontuario = Convert.ToInt64(dr[1].ToString()),
                        Nome = dr[2].ToString(),
                        Sexo = Convert.ToChar(dr[3].ToString()),
                        Idade = Convert.ToInt32(dr[5].ToString()),
                    };
                }

                return paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
