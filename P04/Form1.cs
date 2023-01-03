using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jmeno1 = textBox1.Text;
            string jmeno2 = textBox4.Text;

            DateTime narozen = dateTimePicker1.Value;
            DateTime narozen2 = dateTimePicker2.Value;

            Clovek Daniel = new Clovek(jmeno1, narozen);
            Clovek Filip = new Clovek(jmeno2, narozen2);

            MessageBox.Show(String.Format($"{Daniel.ToString()}"));
            Daniel.NastavJmeno("Daník");
            MessageBox.Show(String.Format($"{Daniel.ToString()}"));

            MessageBox.Show(String.Format($"{Filip.Starsi(Daniel)}"));
        }
    }
}
