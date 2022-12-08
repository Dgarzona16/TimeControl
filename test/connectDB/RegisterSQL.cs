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
    public class RegisterSQL : ConnectDB
    {
        public RegisterSQL()
        { 
        }

        public DataTable GetRegister() 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT R.Id as 'Id', NombreEmpleado as 'Employee', NombreEmpresa as 'Company', Puesto as 'Job', Fecha as 'Date', Horas as 'Time' FROM Registro as R INNER JOIN Empleados as E ON R.IdEmpleado = E.Id INNER JOIN Depto as D ON R.IdDepto = D.Id";
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

        public Boolean AddRegister(Register register)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Registro(IdEmpleado, IdDepto, Fecha, Horas) VALUES(@IdEmpleado, @IdDepto, @Fecha, @Horas)";
                    command.Parameters.AddWithValue("@IdEmpleado", register.Name);
                    command.Parameters.AddWithValue("@IdDepto", register.Depto);
                    command.Parameters.AddWithValue("@Fecha", register.Date);
                    command.Parameters.AddWithValue("@Horas", register.Time);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public DataTable calcTime(string _phone, DateTime startDate, DateTime EndDate)
        {
            string Consult;
            if (_phone == "Employee Phone")
            {
                Consult = "SELECT E.NombreEmpleado as 'Employee', E.NumeroEmpleado as 'Phone', D.NombreEmpresa as 'Company', D.Puesto as 'Job', SUM(R.Horas) as 'Time' FROM Registro as R INNER JOIN Empleados as E ON R.IdEmpleado = E.Id INNER JOIN Depto as D ON R.IdDepto = D.Id WHERE R.Fecha BETWEEN @FechaInicio AND @FechaFin GROUP BY E.NombreEmpleado, E.NumeroEmpleado, D.NombreEmpresa, D.Puesto";
            }
            else
            {
                Consult = $"SELECT E.NombreEmpleado as 'Employee', E.NumeroEmpleado as 'Phone', D.NombreEmpresa as 'Company', D.Puesto as 'Job', SUM(R.Horas) as 'Time' FROM Registro as R INNER JOIN Empleados as E ON R.IdEmpleado = E.Id INNER JOIN Depto as D ON R.IdDepto = D.Id WHERE E.NumeroEmpleado LIKE {_phone} AND R.Fecha BETWEEN @FechaInicio AND @FechaFin GROUP BY E.NombreEmpleado, E.NumeroEmpleado, D.NombreEmpresa, D.Puesto";
            }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = Consult;
                    command.Parameters.AddWithValue("@FechaInicio", startDate.AddDays(-1));
                    command.Parameters.AddWithValue("@FechaFin", EndDate);
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
}
