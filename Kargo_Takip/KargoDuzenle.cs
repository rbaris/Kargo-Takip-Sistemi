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
    public partial class KargoDuzenle : Form
    {
        Kargo secilenKargo;
        Musteri gonderici, alici;

        KargoDBEntities1 db = new KargoDBEntities1();

        public KargoDuzenle(Kargo secilenKargo)
        {
            this.secilenKargo = secilenKargo;
            InitializeComponent();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

           
                Kargo secilen = new Kargo();
                secilen = db.Kargo.First(a => a.Kargo_id == secilenKargo.Kargo_id);

                //secilen.Alici_id = Int32.Parse(lblAlici.Text);
                //secilen.Gonderici_id = Int32.Parse(lblGonderici.Text);
                secilen.Agirlik = Int32.Parse(txtAgirlik.Text);
                secilen.Tur = txtTur.Text;
                secilen.Hacim = Int32.Parse(txtHacim.Text);
                secilen.Kargo_adres = txtAdres.Text;
               //db.Kargo.Remove(secilen);
                db.SaveChanges();
                this.Close();
            

            
            

        }

        private void KargoDuzenle_Load(object sender, EventArgs e)
        {

            gonderici = db.Musteri.First(a => a.Musteri_id == secilenKargo.Gonderici_id);

            alici = db.Musteri.First(a => a.Musteri_id == secilenKargo.Alici_id);


            lblGonderici.Text = gonderici.Musteri_tc_no;
            lblAlici.Text = alici.Musteri_tc_no;
            txtAgirlik.Text = secilenKargo.Agirlik.ToString();
            txtHacim.Text = secilenKargo.Hacim.ToString();
            txtAdres.Text = secilenKargo.Kargo_adres;
            txtTur.Text = secilenKargo.Tur;

        }
    }
}
