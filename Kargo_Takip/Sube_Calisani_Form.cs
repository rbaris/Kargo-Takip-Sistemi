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
    public partial class Sube_Calisani_Form : Form
    {
        public Sube_Calisani_Form()
        {
            InitializeComponent();
        }
        KargoDBEntities1 db = new KargoDBEntities1();
        DataGridViewRow row;
        int id;
      
        private void Sube_Calisani_Form_Load(object sender, EventArgs e)
        {
            label2.Text = "Ücret = (Ağırlık * 2) + (Hacim)";

            
            
            dgvSubeCalisaniKargoDuzenleme.DataSource = db.Kargo.ToList();
            //dgvSubeCalisaniKargoDuzenleme.DataSource = db.Kargo_Durum.ToList();
            //dgvSubeCalisaniKargoDuzenleme.DataSource = db.Sube.ToList();

        }

        private void txtKargoOlustur_Click(object sender, EventArgs e)
        {
            KargoOlustur KargoOlusturForm = new KargoOlustur();
            KargoOlusturForm.Show();


        }

        private void dgvSubeCalisaniKargoDuzenleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            row = dgvSubeCalisaniKargoDuzenleme.Rows[e.RowIndex];

            id = (int)row.Cells[0].Value;
            Kargo secilenKargo = db.Kargo.First(a => a.Kargo_id == id);



            KargoDuzenle kargoDuzenleForm = new KargoDuzenle(secilenKargo);
            kargoDuzenleForm.Show();

        }

        private void btnFaturaHesapla_Click(object sender, EventArgs e)
        {

            id = (int)row.Cells[0].Value;
            Kargo secilenKargo = db.Kargo.First(a => a.Kargo_id == id);

            double ucret = ((secilenKargo.Agirlik) * 2) + ((secilenKargo.Hacim));

            lblUcret.Text = ucret.ToString() + " ₺";

            
            db.SaveChanges();

        }

        private void subeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
