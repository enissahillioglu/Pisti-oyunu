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
    public partial class Form1 : Form
    {
       
        //*************************************************************
        //                                                           **
        //                  ATİYE KILINÇ -16332048                   **
        //                                                           **
        //*************************************************************

        List<KART> oyundakiKartlar = new List<KART>();
        List<KART> ortadakiKartlar = new List<KART>();

        List<KART> oyuncu1Kartlar = new List<KART>();
        List<KART> oyuncu2Kartlar = new List<KART>();


        KART ortadakiSonKart;
        bool oyuncu1;

        List<KART> alinanKartlarOyuncu1 = new List<KART>();
        List<KART> alinanKartlarOyuncu2 = new List<KART>();


        string isim;
        bool rakipKartlari;
        string zorluk;
        public Form1(string a,bool b,string zorluk_)
        {
            isim = a;
            rakipKartlari = b;
            zorluk = zorluk_;
            //MessageBox.Show(zorluk);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            kartlariOlustur();
            ortayaEkle();
            kartlariDagit();
            oyuncu1 = true;
            if (rakipKartlari) {
                listBox2.Visible = true;
            }
            else
            {
                listBox2.Visible = false;
            }
            lbIsim.Text = isim;
            //MessageBox.Show(oyuncu1Kartlar[3].cinsi);
        }

        public void kartlariOlustur()
        {
          
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    KART a = new KART();
                    if (i == 1 || i > 10)
                    {
                        if (i == 1)
                            a.numarasi = "A";
                        if (i == 11)
                            a.numarasi = "J";
                        if (i == 12)
                            a.numarasi = "Q";
                        if (i == 13)
                            a.numarasi = "K";
                    }
                    else
                    {
                        a.numarasi = i.ToString();
                    }
                    if (j == 1)
                        a.cinsi = "maca";
                    if (j == 2)
                        a.cinsi = "kare";
                    if (j == 3)
                        a.cinsi = "kupa";
                    if (j == 4)
                        a.cinsi = "sinek";

                    //a.id = id;
                    //id++;
                    oyundakiKartlar.Add(a);
                }
            }
        }

        Random r = new Random();
        public void ortayaEkle()
        {
            for (int i = 0; i < 4; i++)
            {


                int sayi = r.Next(0, oyundakiKartlar.Count);
                KART a = oyundakiKartlar[sayi];
                oyundakiKartlar.Remove(a);
                ortadakiKartlar.Add(a);
                
            }

        }
        public void kartlariDagit()
        {
            if (oyundakiKartlar.Count > 0)
            {
                log.Items.Add("kartlar dağıtıldı");
               // log.SetSelected(log.Items, true);
                for (int i = 0; i < 4; i++)
                {


                    int sayi = r.Next(0, oyundakiKartlar.Count);
                    KART a = oyundakiKartlar[sayi];
                    oyundakiKartlar.Remove(a);
                    listBox1.Items.Add(a.cinsi + " " + a.numarasi);
                    oyuncu1Kartlar.Add(a);
                }

                for (int i = 0; i < 4; i++)
                {


                    int sayi = r.Next(0, oyundakiKartlar.Count);
                    KART a = oyundakiKartlar[sayi];
                    oyundakiKartlar.Remove(a);
                    listBox2.Items.Add(a.cinsi + " " + a.numarasi);
                    oyuncu2Kartlar.Add(a);
                }

            }
            else log.Items.Add("OYUN BİTTİ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            KART b = new KART();
            b.cinsi = listBox1.Items[listBox1.SelectedIndex].ToString().Split(' ')[0];
            b.numarasi = listBox1.Items[listBox1.SelectedIndex].ToString().Split(' ')[1];
            
            ortadakiKartlar.Add(b);

            
                        
            listBox1.Items.Remove(listBox1.Text);
            log.Items.Add(isim+ " "+b.cinsi+" "+b.numarasi+" attı");

            // oyuncu1Kartlar.Remove(v);
            if (ortadakiKartlar.Count > 0 && ortadakiSonKart!=null)
            {
                if ((b.numarasi == ortadakiSonKart.numarasi || b.numarasi == "J"))
                 {
                   
                    puanla("oyuncu1");
                    }
                 }
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0)
                kartlariDagit();
            oyuncu1 = false;
            //otomatikOyna();
            rakipOyuncu.Enabled = true;
            //label1.Text = 
            //MessageBox.Show(oyundakiKartlar.Count.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if(ortadakiKartlar.Count>0)
            {

                ortadakiSonKart = ortadakiKartlar[ortadakiKartlar.Count - 1];
                label1.Text = ortadakiSonKart.cinsi + " " + ortadakiSonKart.numarasi;
                
            }
            else
            {
                ortadakiSonKart = null;
                label1.Text = "-";
            }

            bilgiOrta.Text = "ortadaki kart sayısı: "+ortadakiKartlar.Count.ToString();
            label4.Text = "toplam kart sayısı: " + oyundakiKartlar.Count.ToString();

            if (oyuncu1)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }

            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            if (log.Items.Count > 0)
            {
                log.SetSelected(log.Items.Count-1, true);

            }
        }

        void otomatikOyna()
        {
            KART a = new KART();
            int rasgele=10;
            if (zorluk == "kolay")
            {
                rasgele = r.Next(0, listBox2.Items.Count);
            }
            else if (zorluk == "zor")
            {
                MessageBox.Show("sss");
                foreach (var item in listBox2.Items)
                {
                    if (item.ToString().Split(' ')[1] == ortadakiSonKart.numarasi)
                    {
                        MessageBox.Show("aynsı var "+ listBox2.Items.IndexOf(item).ToString());
                        rasgele = listBox2.Items.IndexOf(item);
                        break;
                    }
                    
                }
                if (rasgele == 10) {
                    rasgele = r.Next(0, listBox2.Items.Count);
                }
                
               // rasgele = 1;
            }
            a.cinsi = listBox2.Items[rasgele].ToString().Split(' ')[0];
            a.numarasi = listBox2.Items[rasgele].ToString().Split(' ')[1];

            ortadakiKartlar.Add(a);
            // oyuncu2Kartlar.Remove(a);
            listBox2.Items.Remove(listBox2.Items[rasgele]);
            if (ortadakiSonKart != null && a.numarasi == ortadakiSonKart.numarasi || a.numarasi == "J")
            {
                puanla("oyuncu2");
            }
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0)
                kartlariDagit();
            oyuncu1 = true;
        }


        public void puanla(string oyuncu)
        {
            if (ortadakiKartlar.Count == 2)
            {
                if (oyuncu == "oyuncu1")
                    log.Items.Add(isim + "PİŞTİ YAPTI!!");
                else if (oyuncu == "oyuncu2")
                    log.Items.Add("RAKİBİNİZ PİŞTİ YAPTI!!");
                //MessageBox.Show("pişti");
            }
          
                //else
                //    MessageBox.Show("aynı");

                // MessageBox.Show(ortadakiKartlar.Count.ToString());
                if (oyuncu == "oyuncu1")
                {
                    for (int i = 0; i < ortadakiKartlar.Count; i++)
                    {


                        alinanKartlarOyuncu1.Add(ortadakiKartlar[i]);
                        oyuncuu1.Items.Add(ortadakiKartlar[i].cinsi + " " + ortadakiKartlar[i].numarasi);

                        //ortadakiKartlar.Remove(ortadakiKartlar[i]);
                        //MessageBox.Show(i.ToString());
                    }
                    log.Items.Add(isim + " " + ortadakiKartlar.Count + " KAĞIT KAZANDI!!");
                    ortadakiKartlar.Clear();
                    //MessageBox.Show(oyuncu1Kartlar.Count.ToString() + " " + oyuncu2Kartlar.Count.ToString());
                    if (oyuncu1Kartlar.Count == 0 && oyuncu2Kartlar.Count == 0)
                        kartlariDagit();

                }
                else if (oyuncu == "oyuncu2")
                {
                    for (int i = 0; i < ortadakiKartlar.Count; i++)
                    {


                        alinanKartlarOyuncu1.Add(ortadakiKartlar[i]);
                        oyuncuu2.Items.Add(ortadakiKartlar[i].cinsi + " " + ortadakiKartlar[i].numarasi);
                        // ortadakiKartlar.Remove(ortadakiKartlar[i]);

                    }
                    log.Items.Add("RAKİBİNİZ " + ortadakiKartlar.Count + " " + " KAĞIT KAZANDI!!");
                    ortadakiKartlar.Clear();
                    // MessageBox.Show(oyuncu1Kartlar.Count.ToString() + " " + oyuncu2Kartlar.Count.ToString());
                    if (oyuncu1Kartlar.Count == 0 && oyuncu2Kartlar.Count == 0)
                        kartlariDagit();

                }

            
    

        }

       // int beklemeSuresi=3;
        private void rakipOyuncu_Tick(object sender, EventArgs e)
        {
           
                KART a = new KART();
            int rasgele = 10;
            if (zorluk == "kolay")
            {
                rasgele = r.Next(0, listBox2.Items.Count);
            }
            else if (zorluk == "zor")
            {
                //MessageBox.Show("sss");
                foreach (var item in listBox2.Items)
                {
                    if (ortadakiKartlar.Count > 0)
                    {
                        if (item.ToString().Split(' ')[1] == ortadakiSonKart.numarasi )
                        {
                            // MessageBox.Show("aynsı var " + listBox2.Items.IndexOf(item).ToString());
                            rasgele = listBox2.Items.IndexOf(item);
                            break;
                        }
                        else
                        {
                            rasgele = r.Next(0, listBox2.Items.Count);
                        }
                    }
                    else
                    {
                        rasgele = r.Next(0, listBox2.Items.Count);
                    }

                }
                if (rasgele == 10)
                {
                    rasgele = r.Next(0, listBox2.Items.Count);
                }
            }
                a.cinsi = listBox2.Items[rasgele].ToString().Split(' ')[0];
                a.numarasi = listBox2.Items[rasgele].ToString().Split(' ')[1];

                ortadakiKartlar.Add(a);
                // oyuncu2Kartlar.Remove(a);
                listBox2.Items.Remove(listBox2.Items[rasgele]);
               log.Items.Add("rakibiniz "+a.cinsi+a.numarasi+" attı");
            if (ortadakiSonKart != null && a.numarasi == ortadakiSonKart.numarasi || a.numarasi == "J")
                {
                    puanla("oyuncu2");
                }
                if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0)
                    kartlariDagit();
                oyuncu1 = true;
                rakipOyuncu.Enabled = false;
                
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//*************************************************************
//                                                           **
//                  ATİYE KILINÇ -16332048                   **
//                                                           **
//*************************************************************