using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CaptaTecnologia.Repository
{
    public class BaseRepository
    {
        public IDbConnection _dbConnection;
        public BaseRepository(string connection)
        {
            _dbConnection = new SqlConnection(connection.Replace("Anderson.mdf", AppDomain.CurrentDomain.BaseDirectory + "Repository\\Anderson.mdf"));
        }

        protected void CloseConnection()
        {
            if (_dbConnection.State.Equals(ConnectionState.Open))
                _dbConnection.Close();

        }
    }
}
