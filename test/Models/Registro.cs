using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    public class Register
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Depto { get; set; }
        public DateTime Date { get; set; }
        public decimal Time { get; set; }

        public Register(int id, int name, int depto, DateTime date, decimal time)
        {
            Id = id;
            Name = name;
            Depto = depto;
            Date = date;
            Time = time;
        }
        public Register()
        {
        }
    }
}
