using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusuOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ödev: 

            /* 
             İki Text Box ad ve sor ad ayrı ayrı yazılacak. Ad kaç
            karakterse soyad o kadar tekrarlanacak, soyad kaç karakterse ad o kadar 
            tekrarlanacak.
             
             */

            //label1.Text = "";
            //label2.Text = "";

            //string ad = textBox1.Text;
            //string soyad = textBox2.Text;

            //for(int i = 0; i < soyad.Length; i++)
            //{
            //    label1.Text +=i+". "+ ad +"\n";
            //}
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    label2.Text += i + ". " + soyad + "\n";
            //}

            // Ödev 2;
            /*
             
             2 adet textbox başlangıç ve bitiş sayıları girilsin aralıktaki tüm sayıların toplamını veren
            programı yaz */

            label2.Text = "";

            int toplam=0;
           

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {

                toplam += i;
            }
            label2.Text = toplam.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyad_Click(object sender, EventArgs e)
        {

        }
    }
}
