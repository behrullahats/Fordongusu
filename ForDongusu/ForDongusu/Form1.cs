using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // (\n) Bir satır aşağıya atar

            int say = 0;
            for (int i = 1; i <= 100; i++)
            {
                
                if (i % 2 == 1)
                {
                    label1.Text += i + "\n";
                    say++;
                }
               
            }
            MessageBox.Show(say + " Adet Tek Sayı Bulundu");
        }
    }
}
