using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vyrobek;
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                vyrobek = textBox1.Lines[i].Split(';');
                Zbozi zbozi = new Zbozi(vyrobek[0],Convert.ToDouble(vyrobek[1]),Convert.ToDateTime(vyrobek[2]),Convert.ToInt32(vyrobek[3]));
                listBox1.Items.Add(zbozi.Vypis());
            }
        }
    }
}
