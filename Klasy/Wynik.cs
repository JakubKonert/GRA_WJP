using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA_WJP.Klasy
{
    class Wynik
    {
        public Wynik(string nazwa, DateTime data, int ktoraTura)
        {
            this.nazwa = nazwa;
            this.data = data;
            this.ktoraTura = ktoraTura;
        }

        public String nazwa;
        public DateTime data;
        public int ktoraTura;
    }
}
