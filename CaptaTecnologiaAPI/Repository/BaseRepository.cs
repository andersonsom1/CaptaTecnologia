using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Repository
{
    public class BaseRepository
    {
        public IDbConnection _dbConnection;
        public BaseRepository(string connection)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path = path.Replace("API", "");
            _dbConnection = new SqlConnection(connection.Replace("Anderson.mdf",path + "Repository\\Anderson.mdf")) ;
            //_dbConnection = new SqlConnection(connection);
        }

        protected void CloseConnection()
        {
            if (_dbConnection.State.Equals(ConnectionState.Open))
                _dbConnection.Close();

        }
    }
}
