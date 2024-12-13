using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromWednesday.Classes
{
    internal class Temperament
    { 
        public int Scandalous { get; set; }
        public int Smart { get; set; }

        public Temperament(int scandalous, int smart)
        {
            if (scandalous < 0) scandalous = 0;
            if (scandalous > 10) scandalous = 10;
            Scandalous = scandalous;
            Smart = smart;
        }
    }
}
