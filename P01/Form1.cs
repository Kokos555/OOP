using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zdravice zdravice = new Zdravice();
            zdravice.text = textBox1.Text;
            MessageBox.Show(zdravice.Pozdrav(textBox2.Text));
   
            if (int.TryParse(textBox3.Text,out int Pocet)) { 


                Kostka kostka = new Kostka(Pocet);


                MessageBox.Show(string.Format($"{zdravice.Pozdrav(textBox2.Text)} - {kostka.ToString()} - hodil jsi číslo {kostka.Hod()}"));
            }
            else
            {
                Kostka kostka = new Kostka();


                MessageBox.Show(string.Format($"{zdravice.Pozdrav(textBox2.Text)} - {kostka.ToString()} - hodil jsi číslo {kostka.Hod()}"));
            }

        }
    }
}
