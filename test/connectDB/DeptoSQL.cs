using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DataConnection;
using test.Models;
using System.Data.SqlClient;
using System.Data;

namespace test.connectDB
{
    public class DeptoSQL : ConnectDB
    {
        public DeptoSQL()
        {
        }

        public DataTable GetDepto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, NombreEmpresa as 'Company',Puesto as 'Job' FROM Depto";
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        return table;
                    }
                }
            }
        }

        public DataTable SearchDepto(string _depto)
        {
            _depto = _depto.ToUpper().Trim();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Id, NombreEmpresa as 'Company',Puesto as 'Job' FROM Depto WHERE NombreEmpresa LIKE '%{_depto}%'";
                        command.CommandType = CommandType.Text;
                        using (var reader = command.ExecuteReader())
                        {
                            var table = new DataTable();
                            table.Load(reader);
                            return table;
                        }
                    }
                    catch (Exception)
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Id, NombreEmpresa as 'Company',Puesto as 'Job' FROM Depto WHERE Puesto LIKE '%{_depto}%'";
                        command.CommandType = CommandType.Text;
                        using (var reader = command.ExecuteReader())
                        {
                            var table = new DataTable();
                            table.Load(reader);
                            return table;
                        }
                    }
                }
            }
        }

        public int CreateDepto(string _name, string _Job)
        {
            int _id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Depto (NombreEmpresa, Puesto) VALUES (@NombreEmpresa, @Puesto)";
                    command.Parameters.AddWithValue("@NombreEmpresa", _name);
                    command.Parameters.AddWithValue("@Puesto", _Job);
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT @@IDENTITY";
                    _id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return _id;
        }
    }
}
