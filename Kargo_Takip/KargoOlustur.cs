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
    public partial class KargoOlustur : Form
    {
        public KargoOlustur()
        {
            InitializeComponent();
        }
        KargoDBEntities1 db = new KargoDBEntities1();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<Kargo> list = db.Kargo.ToList();

            Kargo eklenenKargo = new Kargo();
            eklenenKargo.Alici_id = Int32.Parse(txtAlici.Text);
            eklenenKargo.Gonderici_id = Int32.Parse(txtGönderici.Text);
            eklenenKargo.Takip_no = (eklenenKargo.Kargo_id + 1010);
            eklenenKargo.Agirlik = Int32.Parse(txtAgirlik.Text);
            eklenenKargo.Tur = txtTur.Text;
            eklenenKargo.Hacim = Int32.Parse(txtHacim.Text);
            eklenenKargo.Kargo_adres = txtAdres.Text;
            db.Kargo.Add(eklenenKargo);
            db.SaveChanges();
            this.Close();
        }


    }
}
