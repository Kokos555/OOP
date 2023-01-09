using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            int cislo = Convert.ToInt32(textBox2.Text);

            Retez test1 = new Retez(veta);
            MessageBox.Show(string.Format($"{test1.ToString()}"));
            MessageBox.Show(string.Format($"{test1.Zkrat()}"));

            Retez test2 = new Retez(veta,cislo);
            MessageBox.Show(string.Format($"{test2.ToString()}"));
            MessageBox.Show(string.Format($"{test2.Zkrat()}"));
        }
    }
}
