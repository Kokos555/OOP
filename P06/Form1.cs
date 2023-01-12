using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            Student test;
            students.Add(new Student("Karel", "Karloň", DateTime.Parse("25.4.2000"), 4));
            students.Add(new Student("Radim", "Pokorny", DateTime.Parse("8.1.2012"), 6));
            students.Add(new Student("Vit", "Novotny", DateTime.Parse("31.12.2003"), 2));
            students.Add(new Student("Filip", "Dusil", DateTime.Parse("15.5.1998"), 0));
            students.Add(new Student("Radek","Novotny", DateTime.Parse("8.4.2006"), 5));

            for (int i = 0; i < students.Count; i++)
            {
                if (test.Vek() >= 18)
                {
                    listBox1.Items.Add(students);
                }
                
            }
        }
    }
}
