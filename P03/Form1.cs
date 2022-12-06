using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            string znak = textBox2.Text;
            Retez retez = new Retez(veta);
            MessageBox.Show(String.Format($"{veta} = {retez.PocetSlov()} slov"));
            veta = retez.Smaz(znak);
            label3.Text = retez.Vypis();
        }
    }
}
