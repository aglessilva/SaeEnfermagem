using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using AppInternacao.Enum;


namespace AppInternacao.Model
{
    public class CRUD : LISTAOBJETOS
    {
        #region METODOS PARA ACESSO A BANCO ADO
        public CRUD() { }

        private int? retorno = null;

        public int? Executar<T>(T obj, Procedure procedure, Acao acao)
        {
            Type infoPropriedade = typeof(T);

            PropertyInfo[] propriedades = infoPropriedade.GetProperties();

            retorno = PopularFields<T>(procedure, propriedades, obj, acao);

            return retorno;
        }

        private int? PopularFields<T>(Procedure procedure, PropertyInfo[] fields, T obejto, Acao acao)
        {
            SqlCommand Comando = null;
            try
            {
                Comando = ComandoSQL(procedure);

                if (acao == Acao.Inserir || acao == Acao.Atualizar || acao == Acao.Verificar)
                {
                    TypeCode tipoPropriedade;

                    foreach (PropertyInfo item in fields)
                    {
                        if (item.GetValue(obejto, null) != null)
                        {
                            tipoPropriedade = Type.GetTypeCode(item.GetValue(obejto, null).GetType());
                            Type tipo = item.PropertyType;

                            if (!tipo.IsEnum)
                            {
                                switch (tipoPropriedade)
                                {
                                    case TypeCode.Single:
                                        {
                                            Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Money));
                                            Comando.Parameters["@" + item.Name].Value = item.GetValue(obejto, null) == null ? null : item.GetValue(obejto, null);
                                            break;
                                        }

                                    case TypeCode.String:
                                        {
                                            string valor = (string)item.GetValue(obejto, null);
                                            if (!string.IsNullOrEmpty(valor))
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.NVarChar));
                                                Comando.Parameters["@" + item.Name].Value = item.GetValue(obejto, null);
                                            }
                                            break;
                                        }
                                    case TypeCode.Int32:
                                        {
                                            int? valor = (int?)item.GetValue(obejto, null);
                                            if (valor > 0)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Int));
                                                Comando.Parameters["@" + item.Name].Value = Convert.ToInt32(valor);
                                            }
                                            break;
                                        }

                                    case TypeCode.DateTime:
                                        {
                                            DateTime? _data = (DateTime?)item.GetValue(obejto, null);
                                            if (_data != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.DateTime));
                                                Comando.Parameters["@" + item.Name].Value = _data;
                                            }
                                            break;
                                        }

                                    case TypeCode.Decimal:
                                        {
                                            decimal? valor = (decimal?)item.GetValue(obejto, null);
                                            if (valor != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Decimal));
                                                Comando.Parameters["@" + item.Name].Value = valor;
                                            }
                                            break;
                                        }

                                    case TypeCode.Int64:
                                        {
                                            long valor = (long?)item.GetValue(obejto, null) == null ? 0 : (long)item.GetValue(obejto, null);

                                            if (valor > 0)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Decimal));
                                                Comando.Parameters["@" + item.Name].Value = valor;
                                            }
                                            break;
                                        }

                                    case TypeCode.Double:
                                        {
                                            double? valor = (double?)item.GetValue(obejto, null);
                                            if (valor != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.BigInt));
                                                Comando.Parameters["@" + item.Name].Value = valor;
                                            }
                                            break;
                                        }

                                    case TypeCode.Boolean:
                                        {
                                            bool? consistencia = (bool?)item.GetValue(obejto, null);
                                            if (consistencia != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Bit));
                                                Comando.Parameters["@" + item.Name].Value = Convert.ToInt16(consistencia);
                                            }
                                            break;
                                        }

                                    case TypeCode.Char:
                                        {
                                            string valor = item.GetValue(obejto, null).ToString().Replace(@"\", "");

                                            if (Regex.Replace(valor.ToString(), @"[0-9]", "") != "\0")
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Char));
                                                Comando.Parameters["@" + item.Name].Value = item.GetValue(obejto, null);
                                            }

                                            break;
                                        }
                                    case TypeCode.Object:
                                        {
                                            byte[] valor = (byte[])item.GetValue(obejto, null);

                                            if (valor != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.VarBinary));
                                                Comando.Parameters["@" + item.Name].Value = item.GetValue(obejto, null);
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                var valor = Convert.ToInt32(item.GetValue(obejto, null));
                                if (valor > 0)
                                {
                                    Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.Int));
                                    Comando.Parameters["@" + item.Name].Value = Convert.ToInt32(valor);
                                }
                            }
                        }
                    }

                }
                else
                {
                    //PropertyInfo item = fields[0];
                    foreach (PropertyInfo item in fields)
                    {
                        if (item.GetValue(obejto, null) != null)
                        {
                            if (Type.GetTypeCode(item.GetValue(obejto, null).GetType()) == TypeCode.Int32)
                            {
                                if (Convert.ToInt32(item.GetValue(obejto, null)) > 0)
                                {
                                    object idUsuario = item.GetValue(obejto, null);
                                    Comando.Parameters.Add(new SqlParameter("@" + item.Name.ToString(), SqlDbType.Int));
                                    Comando.Parameters["@" + item.Name].Value = Convert.ToInt32(idUsuario);
                                }
                            }
                        }
                    }
                }

                Comando.Parameters.Add(new SqlParameter("@IDCLIENTE", SqlDbType.Int));
                Comando.Parameters["@IDCLIENTE"].Value = Sessao.CodigoCliente;

                if (acao == Acao.Verificar)
                    retorno = (int?)Comando.ExecuteScalar();
                else if (acao == Acao.Excluir)
                {
                    Comando.Parameters.Add(new SqlParameter("@RETORNO", SqlDbType.Int)).Direction = ParameterDirection.ReturnValue;
                    Comando.ExecuteNonQuery();
                    retorno = Convert.ToInt32(Comando.Parameters["@RETORNO"].Value);
                }
                else
                    retorno = Comando.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
                //throw new Exception("ERRO AO CADASTRAR: " + sqlEx.Message + " - Na linha" + sqlEx.LineNumber.ToString() + " - da PROCEDURE " + sqlEx.Procedure + " - " + sqlEx.Errors.ToString());
            }

            finally
            {
                DBCONN(Comando);
            }

            return retorno;
        }

        public int? BulkInsert(DataTable dataTable, string _sqlTabela)
        {

            SqlCommand sqlCommand = ComandoSQL(Procedure.VAZIO);
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlCommand.Connection.ConnectionString))
            {
                bulkCopy.DestinationTableName = _sqlTabela;

                try
                {
                    bulkCopy.WriteToServer(dataTable);
                    retorno = 1;
                }
                catch (Exception ex)
                {
                    retorno = 0;
                    throw ex;
                }

                return retorno;
            }
        }
        
        #endregion
    }
}
