using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pisti
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            bool rakipKartlari;
            string zorluk="";

            if (checkBox1.Checked)
            {
                rakipKartlari = true;
            }
            else {
                rakipKartlari = false;
            }
            if (rbKolay.Checked) {
                zorluk = "kolay";
            }
            else if(rbZor.Checked) {
                zorluk = "zor";
            }


            
            Form1 yeni = new Form1(isim,rakipKartlari,zorluk);
            this.Hide();
            yeni.Show();

        }
    }
}
