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
    public partial class Üye_Ol : Form
    {
        public Üye_Ol()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KargoDBEntities1 db = new KargoDBEntities1();

            List<Musteri> musteriTC = db.Musteri.ToList();

            bool x = musteriTC.Any(a => a.Musteri_tc_no.ToString() == txtUyeTcNo.Text && a.Müsteri_email.ToString() == txtUyeMail.Text);
            if (x != true)
            {
                Musteri m = new Musteri();
                m.Müsteri_email = txtUyeMail.Text;
                m.Musteri_ad = txtUyeAd.Text;
                m.Musteri_soyad = txtUyeSoyad.Text;
                m.Musteri_tc_no = txtUyeTcNo.Text;
                m.Musteri_sifre = txtUyeSifre.Text;
                db.Musteri.Add(m);
                db.SaveChanges();

            }
            else
                MessageBox.Show("Kayıtlı Kullanıcı");

        }


        private void checkUyeSifre_CheckStateChanged(object sender, EventArgs e)
        {
            if (txtUyeSifre.UseSystemPasswordChar == true)
                txtUyeSifre.UseSystemPasswordChar = false;
            else if (txtUyeSifre.UseSystemPasswordChar == false)
                txtUyeSifre.UseSystemPasswordChar = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Üye_Ol_Load(object sender, EventArgs e)
        {
            
        }
    }
}
