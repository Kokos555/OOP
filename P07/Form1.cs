using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto test;
        private void button1_Click(object sender, EventArgs e)
        {
            string spz = textBox1.Text;
            int nosnost = Convert.ToInt32(textBox2.Text);
            test = new NakladniAuto(spz, nosnost);
            MessageBox.Show(test.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            test.VylozNaklad(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(test.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.NalozNaklad(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(test.ToString());
        }
    }
}
