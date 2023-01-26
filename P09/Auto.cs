using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09
{
    internal class Auto
    {
        private string znacka;

        private double spotreba;

        private double ujetoCelkem;

        private DateTime okamzikRozjezdu;

        private double dobaJizdyCelkem;

        public bool Jede { get; private set; }

        public Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            dobaJizdyCelkem = 0;
            Jede = false;
        }

        public double VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjeď()
        {
            okamzikRozjezdu = DateTime.Now;
            Jede = true;
        }

        public void Zastav(int km)
        {
            if (Jede)
            {
                Jede = false;
                dobaJizdyCelkem += (DateTime.Now - okamzikRozjezdu).TotalMinutes;
                ujetoCelkem += km;
            }
        }

        public double Celkova_Spotřeba()
        {
            return ujetoCelkem / 100 * spotreba;
        }

        public override string ToString()
        {
            return string.Format($"Detaily auta:\nznačka: {znacka}\nnajeto: {ujetoCelkem} km\nčas jízdy: {dobaJizdyCelkem:F2} minut\nspotřeba: {spotreba}\n" +
                $"auto spotřebovalo {Celkova_Spotřeba()} litrů paliva\nauto momentálně {(Jede ? "jede" : "nejede")}");
        }
    }
}
