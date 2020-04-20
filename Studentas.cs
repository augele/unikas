using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ld
{
    public class Studentas
    {
        public string Name { get; set; }
        public string Pavarde { get; set; }
        public double Vidurkis { get; set; }
        //public double Mediana { get; set; }
        public override string ToString()
        {
            return String.Format("{0, -20}{1, -20}{2, -10}\n", Name, Pavarde, Vidurkis);
        }
    }
}

