using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto moje;
        bool click = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string znacka = textBox1.Text;
            double potreba = Convert.ToDouble(textBox2.Text);
            moje = new Auto(znacka, potreba);
            MessageBox.Show(string.Format($"{moje.ToString()}"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int km = Convert.ToInt32(textBox3.Text);
            if (!click) { 
                moje.Rozjeď();
                click = true;
            }
            else { 
                moje.Zastav(km);
                click = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format($"{moje.ToString()}"));
        }
    }
}
