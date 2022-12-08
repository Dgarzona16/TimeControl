using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Models
{
    public class Depto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public Depto(int id, string name, string job)
        {
            Id = id;
            Name = name;
            Job = job;
        }

        public Depto()
        {
        }
    }
}
