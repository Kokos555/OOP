using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    internal class Student
    {
        public string Jmeno { get; }
        public string Příjmení { get; set; }
        private DateTime datum_narozeni;
        public DateTime Datum_narozeni
        {
            get 
            {
                return datum_narozeni; 
            }
            set 
            {
                datum_narozeni = value; 
                if (datum_narozeni > DateTime.Today)
                {
                    MessageBox.Show(string.Format("Pozor: Budoucí datum!"));
                }


            }
        }

        public Student(string jmeno, string prijmeni, DateTime dnarozen, int znamka)
        {
            Jmeno = jmeno;
            Příjmení = prijmeni;
            Datum_narozeni=dnarozen;
            Znamka = znamka;
        }

  public int znamka;
        public int Znamka
        {
            get
            {
                if (znamka == 0)
                {
                    MessageBox.Show(string.Format("Neproběhla klasifikace!"));
                }
                return znamka;
            }
            set
            { 
                znamka = value;
                
                if (znamka < 1 || znamka > 5)
                {
                    znamka = 0;
                }
               
            }
        }

        public int Vek()
        {
            int v = 0;
            DateTime datum = Datum_narozeni;
            DateTime now = DateTime.Now;
            v = now.Year - datum.Year;
            if (datum.AddYears(v) > now)
            {
                v--;
            }
            return v;
        }

        public bool Sleva()
        {
            if (Vek() < 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string odpoved = string.Format($"Student {Jmeno} {Příjmení}, narozen {Datum_narozeni.ToString("d")} s věkem {Vek()} {(Sleva() ? "má" : "nemá")} nárok na slevu na dopravu. A z testu dostal {Znamka}.");

            return odpoved;
        }






    }
}
