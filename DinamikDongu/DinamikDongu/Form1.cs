using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikDongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Dinamik Döngü Mantığı
            //Örnek 1

            //label1.Text = "";
            //int say = Convert.ToInt32(textBox1.Text);
            //for (int i = 1; i <= say; i++)
            //{
            //    label1.Text += i + ".Sayı \n ";
            //}

            //Örnek 1

            label1.Text = "";
            string ad = textBox1.Text;

            for (int i = 1; i <= ad.Length; i++)
            {
                label1.Text += i + ". Harf \n";

            }

        }
    }
}
