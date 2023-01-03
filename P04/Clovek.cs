using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P04
{
    internal class Clovek
    {
        private string jmeno;
        private DateTime narozen;

        public Clovek(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string Nove_jmeno)
        {
            jmeno = Nove_jmeno;
        }

        public string VypisJmeno()
        {
            return jmeno;
        }
        public int Vek()
        {
            int v = 0;
            DateTime datum = Convert.ToDateTime(narozen);
            DateTime now = DateTime.Now;
            v = now.Year - datum.Year;
            if (datum.AddYears(v) > now)
            {
                v--;
            }
            return v;
        }

        public bool Plnolety()
        {
            if (Vek() >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Starsi(Clovek clovek2)
        {
            if (clovek2.narozen < narozen)
            {
                return String.Format($"{clovek2.jmeno} je starší než {jmeno}");
            }
            else
            {
                return String.Format($"{jmeno} je starší než {clovek2.jmeno}");
            }
        }

        public override string ToString()
        {
            return String.Format($"{jmeno} má {Vek()} let a {(Plnolety() ? "je" : "není")} plnolety");
        }
    }
}
