using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoMaterijal
{
    public abstract class Osoba
    {
        int id { get; set; }
        string name { get; set; }
        string surname { get; set; }


        public override string ToString()
        {
            return name;
        }
    }
}
