using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Dolgozo
    {
        public string nev;
        public string neme;
        public string reszleg;
        public int belepesnev;
        public int ber;

        public Dolgozo(string nev, string neme, string reszleg, int belepesnev, int ber)
        {
            this.nev = nev;
            this.neme = neme;
            this.reszleg = reszleg;
            this.belepesnev = belepesnev;
            this.ber = ber;
        }
    }
}
