using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    internal class Retez
    {
        private string veta;

        public Retez(string veta)
        {
            this.veta = veta;
        }

        public int PocetSlov()
        {
            string[] slova = veta.Split(' ');
            return slova.Length;
        }

        public string Smaz(string znak)
        {
            veta = veta.Replace(znak, "");
            return veta;
        }

        public string Vypis()
        {
            return veta;
        }
    }
}
