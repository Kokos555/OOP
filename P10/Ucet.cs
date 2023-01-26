using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    public enum BankEnum
    {
        Aktivní,
        Zablokovaný,
        Zrušení
    }
    internal class Ucet
    {
        static int pocitadlo = 0;

        private string jmeno;

        private int cislo_uctu;
    }
}
