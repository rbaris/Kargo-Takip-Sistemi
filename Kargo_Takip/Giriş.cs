using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo_Takip
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
            this.Width = 340;

        }

        private void btnMüsteriGiris_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtMusteriEmail.Text))
            //    MessageBox.Show("Çalıştı");
            Musteri m;
            KargoDBEntities1 db = new KargoDBEntities1();

            if (txtMusteriEmail.Text != "" && txtMusteriSifre.Text != "")
            {
                List<Musteri> musteri1 = db.Musteri.ToList();
                try
                {
                    m = musteri1.First(a => a.Müsteri_email.ToString() == txtMusteriEmail.Text && a.Musteri_sifre.ToString() == txtMusteriSifre.Text);
                    if (m != null)
                    {
                        Musteri_Form musteri = new Musteri_Form(m);

                        musteri.Show();
                        this.Hide();


                    }
                }
                catch
                {

                    MessageBox.Show("Email ve Şifre uyuşmuyor");

                }
            }
            else
            {
                MessageBox.Show("Boşlukları Doldurunuz !");
            }


        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {

            Üye_Ol uyeOlForm = new Üye_Ol();
            uyeOlForm.Show();
            uyeOlForm.Location = new Point(620,240);

            //this.Width = 700;
            //this.Height = 470;
        }





        private void btnSubeCalisaniGiris_Click(object sender, EventArgs e)
        {

            //if (txtSifreSube.Text != "" && txtSubeAd.Text != "")
            //{
            //    Sube_Calisani_Form calisan = new Sube_Calisani_Form();
            //    calisan.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Boşlukları Doldurunuz !");
            //}
            Sube_Calisani s;
            KargoDBEntities1 db = new KargoDBEntities1();
            List<Sube_Calisani> kurye = db.Sube_Calisani.ToList();



            try
            {
                s = db.Sube_Calisani.First(a => a.Sube_calisani_ad.ToString() == txtSubeAd.Text && a.Sube_calisani_sifre.ToString() == txtSifreSube.Text);
                if (s != null)
                {
                    Sube_Calisani_Form subeCalisaniForm = new Sube_Calisani_Form();
                    subeCalisaniForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Girilen bilgiler uyuşmuyor");
            }

        }

        private void btnKuryeGiris_Click(object sender, EventArgs e)
        {
            Kurye k;
            KargoDBEntities1 db = new KargoDBEntities1();
            List<Kurye> kurye = db.Kurye.ToList();
            try
            {
                k = kurye.First(a => a.Kurye_ad.ToString() == txtKuryeAd.Text && a.Kurye_sifre.ToString() == txtKuryeSifre.Text);
                if (k != null)
                {
                    Kurye_Form kuryeF = new Kurye_Form();
                    kuryeF.Show();
                }
            }
            catch
            {


                MessageBox.Show("Girilen bilgiler uyuşmuyor");

            }


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Location.X.ToString());
        }
    }
}
