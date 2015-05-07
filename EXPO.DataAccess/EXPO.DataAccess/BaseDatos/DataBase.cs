using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace EXPO.DataAccess.BaseDatos
{
    internal class Database : IDisposable
    {
        DbConnection connection;
        DbProviderFactory factory;
        DbCommand command;
        DbTransaction transaction;

        public Database()
        {
            factory = DbProviderFactories.GetFactory(DataBaseHelper.GetDbProvider());
        }

        public void Open()
        {
            connection = factory.CreateConnection();
            connection.ConnectionString = DataBaseHelper.GetDbConnectionString();
            try
            {
                connection.Open();

            }
            catch
            {
                throw;
            }
        }

        public void Close()
        {
            connection.Close();
        }

        public string CommandText
        {
            set
            {
                if (command == null)
                {
                    command = factory.CreateCommand();

                }
                if (connection == null)
                {
                    this.Open();
                }

                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = value;

            }
        }

        public DbTransaction Transaction()
        {

            transaction = connection.BeginTransaction();

            return transaction;

        }

        public void AddTransaction(DbTransaction oTransaction)
        {
            command.Transaction = oTransaction;
        }

        public string ProcedureName
        {
            set
            {
                if (command == null)
                {
                    command = factory.CreateCommand();
                }
                if (connection == null)
                {
                    this.Open();
                }
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = value;
            }
        }

        public object GetParameter(int index)
        {
            if (command != null)
            {
                try { return command.Parameters[index].Value; }
                catch { return null; }
            }
            return null;
        }

        public object GetParameter(string name)
        {
            if (command != null)
            {
                try { return command.Parameters[name].Value; }
                catch { return null; }
            }
            return null;
        }

        public void AddParameter(string parameterName, DbType parameterType, ParameterDirection parameterDirection, Object parameterValue)
        {
            if (command != null)
            {
                DbParameter parameter = factory.CreateParameter();

                parameter.ParameterName = parameterName;
                parameter.DbType = parameterType;
                parameter.Direction = parameterDirection;
                parameter.Value = parameterValue;
                parameter.SourceColumnNullMapping = true;

                command.Parameters.Add(parameter);
            }
        }

        public void AddParameter(string parameterName, DbType parameterType, ParameterDirection parameterDirection, Object parameterValue, int size)
        {
            if (command != null)
            {
                DbParameter parameter = factory.CreateParameter();

                parameter.ParameterName = parameterName;
                parameter.DbType = parameterType;
                parameter.Direction = parameterDirection;
                parameter.Value = parameterValue;
                parameter.Size = size;
                parameter.SourceColumnNullMapping = true;

                command.Parameters.Add(parameter);
            }
        }

        public IDataReader GetDataReader()
        {
            return command.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection);
        }

        public DataSet GetDataSet()
        {
            DataSet oDataset = new DataSet();
            if (command != null)
            {
                DbDataAdapter oDataAdapter = factory.CreateDataAdapter();
                oDataAdapter.SelectCommand = command;
                oDataAdapter.Fill(oDataset);

            }
            return oDataset;

        }
        public int Execute()
        {
            return command.ExecuteNonQuery();
        }
        public int ExecuteTransaction()
        {
            int retorno = 0;
            retorno = command.ExecuteNonQuery();

            return retorno;
        }
        public void ParameterClear()
        {
            command.Parameters.Clear();
        }

        public object ExecuteScalar()
        {
            return command.ExecuteScalar();
        }

        ~Database()
        {
            this.Dispose();
        }


        #region IDisposable Members

        public void Dispose()
        {
            /*if (connection != null && connection.State == ConnectionState.Open)
             * 
                connection.Close();*/
            connection = null;
            command = null;
            factory = null;
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        #endregion
    }
}
