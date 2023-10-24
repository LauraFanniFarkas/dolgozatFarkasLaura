using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatFarkasLaura
{
    class Bolygo
    {
        public string BolygoNev { get; set; }
        public int HoldjainakSzama { get; set; }
        public double TerfogatanakAranya { get; set; }

        public Bolygo (string sor)
        {
            string[] atmeneti = sor.Split(';');
            BolygoNev = atmeneti[0];
            HoldjainakSzama = Convert.ToInt32(atmeneti[1]);            
            TerfogatanakAranya = double.Parse(atmeneti[2]);

        }
    }
}
