using EkoMaterijal.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EkoMaterijal
{
    public class Materijal
    {
        public int id { get; set; }
        public string name { get; set; }
        public int maxKol { get; set; }
        public float kritKol { get; set; }
        public float kol { get; set; }
        public string mjJedinica { get; set; }
        public float Rezervirano { get; set; }
        public float kolicinaSlobodno { get; set; }

        
        public bool UpdateMat(float kolicina)
        {
            if(kolicina == 0 )
                return false;
            kol += kolicina;
            MaterijalInterface.UpdateAddedSelectedMaterijal(this);
            return true;
        }

        public bool RezervirajMat(float kolicina)
        {
            if(kolicina == 0 )
                return false;
            Rezervirano += kolicina;
            kolicinaSlobodno -= kolicina;
            MaterijalInterface.UpdateRezerviranoMaterijal(this);
            return true;
        }

        public bool Obradi(float kolicina)
        {
            if(kolicina == 0 ) return false;
            Rezervirano -= kolicina;
            kol -=kolicina;
            MaterijalInterface.UpdateObradeniMaterijal(this);

            return true;
        }



    }
}
