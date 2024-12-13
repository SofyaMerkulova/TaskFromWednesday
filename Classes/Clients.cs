using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromWednesday.Classes
{
    internal class Clients
    {
        public string Name { get; set; }
        public string PassportNumber { get; set; }
        public Problems Problems { get; set; }
        public Temperament Temperament { get; set; }

        public Clients(string name, string passportNumber, Problems problems, Temperament temperament)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problems = problems;
            Temperament = temperament;
        }
    }
}
