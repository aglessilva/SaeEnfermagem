﻿using System;
using System.Collections;
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
                                            int valor = (int)item.GetValue(obejto, null);
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
                                            if (item.PropertyType.Namespace.Equals("System.Collections.Generic"))
                                                break;

                                            int tipoParam;
                                            dynamic valor = null;

                                            if (item.PropertyType.IsArray)
                                            {
                                                valor = (byte[])item.GetValue(obejto, null);
                                                tipoParam = 1;
                                            }
                                            else
                                            {
                                                valor = (TimeSpan)item.GetValue(obejto, null);
                                                tipoParam = 2;
                                            }

                                            if (valor != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, tipoParam == 1 ? SqlDbType.Binary : SqlDbType.Time));
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
                    retorno = 0;
                   // Comando.Parameters.Add(new SqlParameter("@RETORNO", SqlDbType.Int)).Direction = ParameterDirection.ReturnValue;
                    retorno = Comando.ExecuteNonQuery() == 1 ? 2 : 200;
                   // retorno = Convert.ToInt32(Comando.Parameters["@RETORNO"].Value);
                }
                else
                {
                    retorno = 0;
                    Comando.Parameters.Add(new SqlParameter("@IDUSUARIO", SqlDbType.Int));
                    Comando.Parameters["@IDUSUARIO"].Value = Sessao.Usuario.Id;

                    var newIdParam = Comando.Parameters.Add("@Identity", SqlDbType.Int);
                    newIdParam.Direction = ParameterDirection.Output;
                    retorno = Comando.ExecuteNonQuery();
                   
                    if (newIdParam.Value != DBNull.Value)
                        retorno = Convert.ToInt32(newIdParam.Value);

                    return retorno;
                   
                }
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

        //================================= BLOCO ESPECIFICO PARA ACÕES DE PRESCRIÇÃO==============================================
        public int InsertPrescricao(PrescricaoMedica prescricaoMedica)
        {
            SqlCommand command = ComandoSQL(Procedure.SP_ADD_PRESCRICAO);

            int ret = 0;
            try
            {
                command.Parameters.Add(new SqlParameter("@Id", prescricaoMedica.Id));
                command.Parameters.Add(new SqlParameter("@IdCliente", Sessao.CodigoCliente));
                command.Parameters.Add(new SqlParameter("@IdChavePrescricao", prescricaoMedica.IdChavePrescricao ));
                command.Parameters.Add(new SqlParameter("@Prontuario", prescricaoMedica.Prontuario));
                //command.Parameters.Add(new SqlParameter("@DataHorario", prescricaoMedica.DataHorario));
                command.Parameters.Add(new SqlParameter("@Intervalo", prescricaoMedica.Intervalo));
                command.Parameters.Add(new SqlParameter("@Prescricao", prescricaoMedica.Prescricao));
                var newIdParam = command.Parameters.Add("@Indentity", SqlDbType.Int);
                newIdParam.Direction = ParameterDirection.Output;

                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();

                command.ExecuteNonQuery();
                if (newIdParam.Value != DBNull.Value)
                    ret = Convert.ToInt32(newIdParam.Value);

                command.Dispose();
                command.Clone();
            }
            catch (SqlException ex)
            {
                command.Dispose();
                command.Clone();
                throw ex;
            }

            return ret;
        }

        public DataTable GetDataTable(Procedure procedure, SqlParameter[] sqlParameter)
        {
            return GetDataTable(sqlParameter, procedure);
        }
        //==========================================================================================================================
        #endregion
    }
}
