using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kargo_Takip
{
    public partial class Kurye_Form : Form
    {
        Kargo secilikargo;
        Kargo aranankargo;
        public Kurye_Form()
        {
            InitializeComponent();
            
        }
        KargoDBEntities1 db = new KargoDBEntities1();
        private void Kurye_Form_Load(object sender, EventArgs e)
        {
            dgvKuryeKargo.DataSource=db.Kargo.ToList();

            cmbBoxIslemSube.DataSource = db.Sube.ToList();
            cmbBoxIslemSube.DisplayMember = "Sube_adi";
            cmbBoxIslemSube.ValueMember = "Sube_id";

        }

        private void dataGridVdiew1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                KargoDBEntities1 dbb = new KargoDBEntities1();
                Kargo_Durum yenidurum = new Kargo_Durum();

                yenidurum.Kargo_id = secilikargo.Kargo_id;
                yenidurum.Islem_sube = cmbBoxIslemSube.Text.ToString();
                yenidurum.islem = cmBoxIslemDurumu.SelectedItem.ToString();
                yenidurum.Islem_tarihi = DateTime.Now;

                dbb.Kargo_Durum.Add(yenidurum);
                dbb.SaveChanges();
                //Response.Redirect("~/Default.aspx");
                dgvKuryeKargoDurum.DataSource = db.Kargo_Durum.Where(a => a.Kargo_id == aranankargo.Kargo_id).ToList();
            }
            catch(DbEntityValidationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int ara = Int32.Parse(txtTakipNo.Text);
                aranankargo = db.Kargo.First(a => a.Takip_no == ara);
                secilikargo = aranankargo;
                dgvKuryeKargoDurum.DataSource = db.Kargo_Durum.Where(a => a.Kargo_id == aranankargo.Kargo_id).ToList();
            }
            catch 
            {
                MessageBox.Show("Girilen takip no yanlıştır");
            }
            

            //dgvKuryeKargoDurum.DataSource = db.Kargo.Where(a => a.Takip_no == ara).ToList();



            //  dataGridVdiew1.DataSource = db.Kargo.Where(a => a.Takip_no).ToList();
        }
    }
}
