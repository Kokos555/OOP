using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
{
    internal class Retez
    {
        private string veta;
        private int cislo;

        public Retez(string veta)
        {
            this.veta = veta;
            cislo = 1;
        }

        public Retez(string veta, int cislo)
        {
            this.veta = veta;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return veta;
        }

        public void Zkrat()
        {
            string[] slova = veta.Split(' ');
            veta = string.Empty;
            slova[slova.Length - 1] = ".";

            for (int i = 0; i < slova.Length; i++)
            {
                if (cislo <= 0)
                {
                    veta = "";
                }
                else
                {
                    if (i != cislo)
                    {
                        veta += String.Format($"{slova[i]} ");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
