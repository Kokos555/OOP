using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    internal class Zbozi
    {
        private string nazev_produktu;

        private double cena_produktu;

        private DateTime dv;

        private int mt;

    

        public Zbozi(string nazev_produktu, double cena_produktu, DateTime dv, int mt)
        {
            this.nazev_produktu = nazev_produktu;
            this.cena_produktu = cena_produktu;
            this.dv = dv;
            this.mt = mt;
        }

        public int MinTrvanlivostDny()
        {
            int dny = 0;
            DateTime n = DateTime.Now;
            DateTime ds = dv;
            ds = ds.AddDays(mt);
            TimeSpan trvanlivost = ds - n;
            dny = trvanlivost.Days;
            return dny;
        }

        public void NovaCena()
        {
            int pocet_dnu = MinTrvanlivostDny();
            if (pocet_dnu <= -10)
            {
                cena_produktu = 0;
            } else if (pocet_dnu <= 0)
            {
                cena_produktu = cena_produktu - cena_produktu * 0.5;
            } else if (pocet_dnu <= 3)
            {
                cena_produktu = cena_produktu - cena_produktu * 0.25;
            }
        }

        public string Vypis()
        {
            string text;
            int trvan = MinTrvanlivostDny();
            NovaCena();
            if (cena_produktu != 0)
            {
                if (trvan >= 0) { 
                    text = string.Format($"{nazev_produktu};{cena_produktu};{dv:d};{mt};Trvanlivost produktu je ještě {trvan}");
                }else
                {
                    text = string.Format($"{nazev_produktu};{cena_produktu};{dv:d};{mt}; trvanlivost byla překročena o {Math.Abs(trvan)}");
                }
            }
            else
            {
                text = string.Format($"{nazev_produktu};neprodejné;{dv:d};{mt};Produkt je prošlí více jak deset dní, konkrétně: {Math.Abs(trvan)}");
            }
            return text;
        }
    }
}
