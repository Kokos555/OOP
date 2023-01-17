using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    internal class NakladniAuto
    {
        private string spz;

        private int nosnost;

        public int Hmotnost_nakladu { get; private set; }

        public NakladniAuto(string spz, int nosnost)
        {
            Hmotnost_nakladu = 0;
            this.spz = spz;
            this.nosnost = nosnost;
        }

        public void NalozNaklad(int naklad)
        {
            Hmotnost_nakladu += naklad;
            if (nosnost < Hmotnost_nakladu)
            {
                Hmotnost_nakladu 
            }
        }

        public override string ToString()
        {
            return string.Format($"Založil jsi nákladní auto s SPZ ({spz}) s nosností {nosnost} tun");
        }
    }
}
