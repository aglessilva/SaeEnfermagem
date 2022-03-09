using AppInternacao.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AppInternacao.Model
{
    public class LISTAOBJETOS : SQLDBCONNECTION
    {
        #region VARIAVEIS DE AMBIENTE
        private CRUD DB = null;
        SqlCommand cmd = null;
        #endregion

        #region METODOS DE LISTAGEM DE OBJETOS DE BANCO
        public LISTAOBJETOS() { }

        protected SqlCommand ComandoSQL(Procedure procedure )
        {
            try
            {
                cmd = new SqlCommand();

                cmd.Connection = DBCONN(cmd);
                if (procedure != Procedure.VAZIO)
                {
                    cmd.CommandText = procedure.ToString();
                    cmd.CommandType = CommandType.StoredProcedure;
                }
            }

            catch (SqlException sqlEx)
            {
                throw new Exception("Erro no comando SQL: " + sqlEx.Message);
            }

            return cmd;
        }

        private int ExceutarAcao<T>(T obj, Acao _acao, Procedure NomeProcedure)
        {
            DB = new CRUD();
            SqlCommand cmd = PopulaPropriedades<T>(obj, NomeProcedure);
            return 0;
        }

        private SqlCommand PopulaPropriedades<T>(T obejto, Procedure procedure)
        {
            SqlCommand Comando = null;
            try
            {
                Type propriedade = typeof(T);
                PropertyInfo[] ColecaoPropriedade = propriedade.GetProperties();

                Comando = ComandoSQL(procedure);

                Comando.Parameters.Add(new SqlParameter("@IDCLIENTE", SqlDbType.Int));
                Comando.Parameters["@IDCLIENTE"].Value = Sessao.CodigoCliente;

                TypeCode tipoPropriedade;
                foreach (PropertyInfo item in ColecaoPropriedade)
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
                                        if (tipo.IsArray)
                                        {
                                            byte[] valor = (byte[])item.GetValue(obejto, null);
                                            if (valor != null)
                                            {
                                                Comando.Parameters.Add(new SqlParameter("@" + item.Name, SqlDbType.VarBinary));
                                                Comando.Parameters["@" + item.Name].Value = item.GetValue(obejto, null);
                                            }
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

            catch (SqlException sqlex)
            {
                throw new Exception("Erro" + sqlex.Message);
            }

             
            return Comando;
        }

        protected internal  List<T> ListaGenerica<T>(Procedure _procedure, T obj)
        {
            List<T> Lista = new List<T>();
            try
            {
                Type tipoObjeto = typeof(T);
                PropertyInfo[] propriedadesObj = tipoObjeto.GetProperties();


                if (obj != null)
                {
                    cmd = PopulaPropriedades<T>(obj, _procedure);

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        T result = (T)Activator.CreateInstance(typeof(T), true);
                        PropertyInfo[] properties = propriedadesObj;
                        int i = 0;

                        foreach (PropertyInfo item in propriedadesObj)
                        {
                            Type tipo = item.PropertyType;

                            for (int w = 0; w < dr.FieldCount; w++)
                            {
                                if (dr.GetName(w).Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                                // if (!tipo.IsEnum)
                                {
                                    if (item.GetValue(obj, null) != null)
                                        if (Type.GetTypeCode(item.GetValue(obj, null).GetType()) == TypeCode.Char)
                                            properties[i].SetValue(result, Convert.ToChar(dr[item.Name]), null);
                                        else
                                            properties[i].SetValue(result, dr[item.Name] == DBNull.Value ? null : dr[item.Name], null);
                                    else
                                        properties[i].SetValue(result, dr[item.Name] == DBNull.Value ? null : dr[item.Name], null);
                                    break;
                                }
                            }
                            i++;
                           
                        }
                        Lista.Add(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            finally
            {
                DBCONN(cmd);
            }

            return Lista;
        }

        public T RetornaObjeto<T>(Procedure _procedure, T obj)
        {
            try
            {
                Type tipoObjeto = typeof(T);
                PropertyInfo[] propriedadesObj = tipoObjeto.GetProperties();
                T result = (T)Activator.CreateInstance(typeof(T), true);

                if (obj != null)
                {
                    cmd = PopulaPropriedades<T>(obj, _procedure);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int i = 0;
                            PropertyInfo[] properties = propriedadesObj;

                            foreach (PropertyInfo item in propriedadesObj)
                            {
                                Type tipo = item.PropertyType;
                                for (int w = 0; w < dr.FieldCount; w++)
                                {
                                    if (dr.GetName(w).Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                                        if (!tipo.IsEnum)
                                        {
                                            if (item.GetValue(obj, null) != null)
                                                if (Type.GetTypeCode(item.GetValue(obj, null).GetType()) == TypeCode.Char)
                                                    properties[i].SetValue(result, Convert.ToChar(dr[item.Name]), null);
                                                else
                                                    properties[i].SetValue(result, dr[item.Name] == DBNull.Value ? null : dr[item.Name], null);
                                            else
                                                properties[i].SetValue(result, dr[item.Name] == DBNull.Value ? null : dr[item.Name], null);
                                            break;
                                        }
                                        else
                                        {
                                            properties[i].SetValue(result, dr[item.Name] == DBNull.Value ? null : dr[item.Name], null);
                                        }
                                }
                                i++;
                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

            finally
            {
                DBCONN(cmd);
            }
        }
       
        public DataTable GetDataTable(SqlParameter[] sqlParameters, Procedure procedure)
        {
            DataTable dataTable = null;
            try
            {
                SqlCommand command = ComandoSQL(procedure);
                command.Parameters.AddRange(sqlParameters);

                if (command.Connection.State == ConnectionState.Closed)
                    command.Connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                DataTable schematb = dataReader.GetSchemaTable();
                dataTable = new DataTable();
                DataColumn dataColumn = null;
                DataRow dataRow = null;
                foreach (DataRow item in schematb.Rows)
                {
                    dataColumn = new DataColumn(item[0].ToString());
                    dataTable.Columns.Add(dataColumn);
                }

                while (dataReader.Read())
                {
                    dataRow = dataTable.NewRow();

                    foreach (DataColumn item in dataTable.Columns)
                    {
                        dataRow[item.Ordinal] = dataReader[item.Ordinal].ToString();
                    }
                    dataTable.Rows.Add(dataRow);
                }


                command.Connection.Close();
            }
            catch (Exception exDataTable)
            {
                throw exDataTable;
            }

            return dataTable;
        }

        #endregion
    }
}
