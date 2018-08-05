using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    class FormApplication : Form
    {
        private Timer zaman;
        private Ucaklar Ucak;
        private Savar ucakSavar;
        private Mermi ucakSavarMermisi;
        private List<Ucaklar> UcaklarListesi = new List<Ucaklar>();
        private List<Mermi> MermilerinListesi = new List<Mermi>();
        private List<Timer> UcaklarinZamani = new List<Timer>();
        private Random rnd = new Random();
        //mermiDegiskeni ve ucakDegiskeninin gorevileri kendilerine ait Listelerin indexlecileridir.
        private int ucakDegiskeni;
        private int mermiDegiskeni;
 

        public FormApplication(int width, int height)
        {
            mermiDegiskeni = -1;
            Width = width;
            Height = height;

            //Buradaki for dongusu UcaklarListesine 100tane Ucak nesnesinden yertahsisi yapmaktadir.
            for (ucakDegiskeni = 0; ucakDegiskeni < 100; ucakDegiskeni++)
            {
                Ucak = new Ucaklar();
                Ucak.Y = -40;
                Ucak.X = rnd.Next(1,17) * 40;  // Burada Ucaklarin yataydaki baslangic konumu rastgele belirlenmistir.
                UcaklarListesi.Add(Ucak);
            }

            ucakSavar = new Savar();
            ucakSavar.Y = 520;
           



            KeyDown += MainApplication_KeyDown;

            //buradaki paint temsilcisi 6 tane ucagin forma cizdirilecegi metodlari cagirilmistir.
            //Yani oyun basladıgında yatayda rastgele dagilmis 6 ucak cizilecektir bazi ucaklar üst üste olabilir.
            Paint += MainApplication_Paint;
            Paint += MainApplication_Paint1;
            Paint += MainApplication_Paint2;
            Paint += MainApplication_Paint3;
            Paint += MainApplication_Paint4;
            Paint += MainApplication_Paint5;
            Paint += MainApplication_Paint6;

            Load += MainApplication_Load;


            Paint += MainApplication_Paint10;


            BackColor = Color.DarkSlateGray;

            DoubleBuffered = true;

            zaman = new Timer();
            zaman.Interval = 11;
            zaman.Tick += Zaman_Tick;
            zaman.Start();
        }

        private void MainApplication_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ucaksavarı hareket ettirmek için sag/sol yön tuşlarını kullanınız.\n Ateş etmek için boşluk tuşunu kullanınız. \nOyunun Başlaması için lütfen Enter Tuşuna basınız. ", "Oyuna Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
        }

        private void MainApplication_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ucakSavar.X -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                ucakSavar.X += 10;
            }
            //Space tusuna basildiginda MermilerinListesine ucakSavarMermisi nesnesinden yertahsisi yapmaktadir
            //mermiDegiskeni kurucuda -1 atanmistir, her space tusuna basildiginda ise mermiDegiskeni arttirilarak, MermilerinListesinin indexleyicisi olmustur.
            if (e.KeyCode == Keys.Space)
            {
                ucakSavarMermisi = new Mermi();
                MermilerinListesi.Add(ucakSavarMermisi);
                mermiDegiskeni++;
                MermilerinListesi[mermiDegiskeni].Y = 520;
                MermilerinListesi[mermiDegiskeni].X = ucakSavar.X + 13;


                Paint += MainApplication_Paint11;
            }
        }


        private void MainApplication_Paint1(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }
        private void MainApplication_Paint2(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }
        private void MainApplication_Paint3(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }
        private void MainApplication_Paint4(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }
        private void MainApplication_Paint5(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }
        private void MainApplication_Paint6(object sender, PaintEventArgs e)
        {
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
            {
                if (MermilerinListesi[mermiDegiskeni].X + 15 > UcaklarListesi[ucakDegiskeni].X && MermilerinListesi[mermiDegiskeni].X < UcaklarListesi[ucakDegiskeni].X + 40 && MermilerinListesi[mermiDegiskeni].Y < UcaklarListesi[ucakDegiskeni].Y + 40)
                {
                    UcaklarListesi.RemoveAt(ucakDegiskeni);
                    MermilerinListesi.RemoveAt(mermiDegiskeni);
                    mermiDegiskeni--;
                }
            }
            ucakDegiskeni++;
        }

        /*Burada ucaklar oyun alaninin en altına ulastiginda oyunun sonlanması ve bastan acılmasi saglanmistir
         * Ucagin genislik ve yukseklik degerleri ile koordinat degelerinin, mermi resminin bu degerlerin icene girmesiyle bir kosul olusturmaktadir
         * bu kosulun icine giren mermi ve ucak yok edilmekte ve mermiDegiskeni bir azaltilarak tekrar mermi olusturulmasi icin tusa basilmasiyla
         * mermiDegiskeni mermiIndex degiskeni ekranda birden fazla merminin cıkarilmasi durumunu kontrol etmektedir. 
         * yani ekranda birden fazla mermi varsa MermilerinListesi.count sifirdan buyuk olmaktadir.
         * program ilk calistirildiginda mermi ve ucagin carpisip carpismadigi kontrolu ilk bu metottan baslar.
         * ucakIndex degiskeni for dongusunde ucaga ilk carpan mermi hangi ucagin hangi indisinde oldugunu bulur ve o indisli ucagi yok etmektedir.
        */
        private void MainApplication_Paint(object sender, PaintEventArgs e)
        {
            ucakDegiskeni = 0;
            if (UcaklarListesi[ucakDegiskeni].Y > 520)
            {
                Application.Restart();
            }
            UcaklarListesi[ucakDegiskeni].ucakCizdir(e.Graphics);
            UcaklarListesi[ucakDegiskeni].Y += 1;
            for (int ucakIndex = 0; ucakIndex < 8; ucakIndex++)
            {
                for (int mermiIndex = 0; mermiIndex < MermilerinListesi.Count; mermiIndex++)
                {
                    if (MermilerinListesi.Count == mermiDegiskeni + 1 && MermilerinListesi.Count != 0)
                    {
                        if (MermilerinListesi[mermiIndex].X + 15 > UcaklarListesi[ucakIndex].X && MermilerinListesi[mermiIndex].X < UcaklarListesi[ucakIndex].X + 40 && MermilerinListesi[mermiIndex].Y < UcaklarListesi[ucakIndex].Y + 40)
                        {
                            UcaklarListesi.RemoveAt(ucakIndex);
                            MermilerinListesi.RemoveAt(mermiIndex);
                            mermiDegiskeni--;
                        }
                    }
                }
            }
            ucakDegiskeni++;

        }

        //burada mermi oyun alaninin en ustune ulastiginda yok olmasi saglanmistirç
        private void MainApplication_Paint11(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <= MermilerinListesi.Count - 1; i++)
            {
                MermilerinListesi[i].mermiCizdir(e.Graphics);
                if (MermilerinListesi[i].Y < 0)
                {
                    MermilerinListesi.RemoveAt(i);
                    mermiDegiskeni--;
                }
            }
        }

        //ucakSavar'in yatayda hareket ederken oyun alaninin disina cikilmamasi saglanmistir
        private void MainApplication_Paint10(object sender, PaintEventArgs e)
        { 
            if(ucakSavar.X <= 0)
            {
                ucakSavar.X = 0;
            }
            if (ucakSavar.X >= 740)
            {
                ucakSavar.X = 740;
            }
            ucakSavar.savarCizdir(e.Graphics);
        }

        private void Zaman_Tick(object sender, EventArgs e)
        {
            Invalidate(); //uygulamaya cizim yapilmasi gerktigini soyler.
            for (int i = 0; i <= MermilerinListesi.Count - 1; i++)//burada eklenen herbir merminin yukari gitmesi saglanmsitir.
            {
                MermilerinListesi[i].Y -= 1;
            }
        }
    }
}

