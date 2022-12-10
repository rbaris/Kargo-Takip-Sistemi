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
    public partial class Musteri_Form : Form
    {

        Musteri GirenMusteri { get; set; }
        public Musteri_Form(Musteri m)
        {
            
            InitializeComponent();
            this.GirenMusteri = m;
        }

        private void btnMüsteriBilgiGuncelle_Click(object sender, EventArgs e)
        {
            txtMüsteriAd.ReadOnly = false;
            txtMüsteriSoyad.ReadOnly = false;
            txtMüsteriSifre.ReadOnly = false;
            txtMüsteriEmail.ReadOnly = false;


        }

        private void Musteri_Form_Load(object sender, EventArgs e)
        {
            KargoDBEntities1 db = new KargoDBEntities1();

            dgvKargolar.DataSource = db.Kargo.Where(a => a.Alici_id == GirenMusteri.Musteri_id || a.Gonderici_id == GirenMusteri.Musteri_id).ToList();
            //dgvKargolar.DataSource = db.Kargo.ToList();

            txtMüsteriAd.Text = GirenMusteri.Musteri_ad;
            txtMüsteriSoyad.Text = GirenMusteri.Musteri_soyad;
            txtMüsteriTC.Text = GirenMusteri.Musteri_tc_no;
            txtMüsteriEmail.Text = GirenMusteri.Müsteri_email;
            txtMüsteriSifre.Text = GirenMusteri.Musteri_sifre;

            txtMüsteriTC.ReadOnly = true;
            txtMüsteriAd.ReadOnly = true;
            txtMüsteriSoyad.ReadOnly = true;
            txtMüsteriSifre.ReadOnly = true;
            txtMüsteriEmail.ReadOnly = true;

            




        }

        private void btnDegisikleriKaydet_Click(object sender, EventArgs e)
        {
            KargoDBEntities1 db = new KargoDBEntities1();

            Musteri musteriduzenlenen = db.Musteri.First(a => a.Musteri_tc_no == GirenMusteri.Musteri_tc_no);


            musteriduzenlenen.Musteri_ad = txtMüsteriAd.Text;
            musteriduzenlenen.Musteri_soyad = txtMüsteriSoyad.Text;
            musteriduzenlenen.Müsteri_email = txtMüsteriEmail.Text;
            musteriduzenlenen.Musteri_sifre = txtMüsteriSifre.Text;
            db.SaveChanges();

            txtMüsteriAd.ReadOnly = true;
            txtMüsteriSoyad.ReadOnly = true;
            txtMüsteriSifre.ReadOnly = true;
            txtMüsteriEmail.ReadOnly = true;
        }

        private void dgvKargolar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKargolar.Rows[e.RowIndex];

            int id = (int)row.Cells[0].Value;

            KargoDBEntities1 db = new KargoDBEntities1();

            Kargo secilikargo = db.Kargo.First(a => a.Takip_no == id);

            Musteri_kargo_takip takip = new Musteri_kargo_takip(secilikargo);
            takip.Show();
        }
    }
}
