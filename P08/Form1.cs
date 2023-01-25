using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atlet idk;

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno = textBox1.Text;
            idk = new Atlet(jmeno);
            MessageBox.Show(idk.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int beh = Convert.ToInt32(textBox2.Text);
            idk.Behej(beh);
            idk.ZjistiUnavu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int spanek = Convert.ToInt32(textBox3.Text);
            idk.Spanek(spanek);
            idk.ZjistiUnavu();
        }
    }
}
