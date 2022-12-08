using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Employee(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public Employee()
        {
        }
    }
}
