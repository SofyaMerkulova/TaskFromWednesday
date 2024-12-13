using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromWednesday.Classes
{
    internal class Problems
    {
        public int Number { get; set; }
        public string Description { get; set; }

        public Problems(int number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
