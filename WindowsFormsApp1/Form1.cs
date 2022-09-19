using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        public int najwiekszy_wynik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You start game! Let's go";
            timer1.Start();
            licznik++;
            label1.Text = licznik.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            licznik = 0;
            label1.Text = licznik.ToString();
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false; 
        }
    }
}
