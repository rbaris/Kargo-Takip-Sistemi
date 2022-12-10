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
    public partial class Musteri_kargo_takip : Form
    {

        Kargo Girenkargo { get; set; }
        public Musteri_kargo_takip(Kargo krg)
        {
            InitializeComponent();
            Girenkargo = krg;
        }

        private void Musteri_kargo_takip_Load(object sender, EventArgs e)
        {
            KargoDBEntities1 db = new KargoDBEntities1();
            dgv_kargotakip.DataSource = db.Kargo_Durum.Where(a => a.Kargo_id == Girenkargo.Kargo_id).ToList();
        }
    }
}
