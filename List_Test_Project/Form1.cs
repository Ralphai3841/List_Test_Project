using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Test_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Mahzar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(4);
            sayilar.Add(8);
            sayilar.Add(15);
            sayilar.Add(16);
            sayilar.Add(23);
            sayilar.Add(42);
            foreach (int s in sayilar)
            {
                if (s % 2 ==0 )
                {
                    listBox2.Items.Add(s);
                }
            }

            if (sayilar.Contains(42))
            {
                MessageBox.Show("Bu sayı var");
            }
            else
            {
                MessageBox.Show("Bu sayı yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();

            kisi.Add(new Kisiler()
            {
                ADI ="Albert",
                SOYADI="Einstein",
                MESLEKI="Öğretmen"
            });

            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI+ " " + k.MESLEKI);
            }
        }
    }
}
