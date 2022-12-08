using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace test.DataConnection
{
    public abstract class ConnectDB
    {
        private readonly string _connectionString;

        public ConnectDB()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
