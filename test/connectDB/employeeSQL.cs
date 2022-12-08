using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using test.DataConnection;
using test.Models;

namespace test.connectDB
{
    public class employeeSQL : ConnectDB
    {
        public employeeSQL()
        {
        }
        
        public DataTable GetEmployee()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, NombreEmpleado as 'Employee', NumeroEmpleado as 'Phone' FROM Empleados";
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
        
        public DataTable SearchEmployee(string _employee)
        {
            _employee = _employee.ToUpper().Trim();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"SELECT Id, NombreEmpleado as 'Employee', NumeroEmpleado as 'Phone' FROM Empleados WHERE NombreEmpleado LIKE '%{_employee}%'";
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

        public int CreateEmployee(string _name, string _phone)
        {
            int _id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO Empleados (NombreEmpleado, NumeroEmpleado) VALUES ('{_name}', '{_phone}')";
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        command.CommandText = "SELECT @@IDENTITY";
                        _id = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception)
                    {
                        _id = -1;
                    }
                }
            }
            return _id;
        }
    }
}
