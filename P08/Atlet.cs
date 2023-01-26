using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    internal class Atlet
    {
        private string jmeno;
        private int unava;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
                if (!char.IsUpper(jmeno[0]))
                {
                    jmeno = char.ToUpper(jmeno[0]) + jmeno.Substring(1);
                }
            }
        }

        public Atlet(string jmeno)
        {
            Jmeno = jmeno;
            unava = 0;
        }

        public void Behej(int pocet_km)
        {
            
            for (int i = 0; i< pocet_km; i++)
            {
                unava += 10;
                if (unava == 200)
                {
                    MessageBox.Show(string.Format($"Běžec {Jmeno} odmítl běhat, protože je moc unavený, potřebuje se prospat. Běžec uběhl {pocet_km} kilometrů, je to více, než kdy uběhneš ty."));
                    break;
                }
            }
        }

        public void Spanek(int hodiny)
        {
            if (hodiny == 1 && unava >= 100)
            {
                unava -= 100;
                MessageBox.Show($"{Jmeno} se vyspal na hodinu a jeho únava kleska na {unava}");
            }else if (hodiny != 0)
            {
                unava = 0;
                MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
            }
        }


        public void ZjistiUnavu()
        {
            MessageBox.Show($"Únava atleta {Jmeno} je {unava}");
        }

        public override string ToString()
        {
            return string.Format($"Založil jsi atleta se jménem {Jmeno}");
        }
    }
}
