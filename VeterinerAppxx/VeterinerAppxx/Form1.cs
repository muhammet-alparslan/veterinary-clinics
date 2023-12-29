using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerAppxx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form Aşılar = new Aşılar();
            Aşılar.Show();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form HAYVAN = new HAYVAN();
            HAYVAN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ilaç = new ilaç();
            ilaç.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form muayane = new muayane();
            muayane.Show();
        }
    }
}
