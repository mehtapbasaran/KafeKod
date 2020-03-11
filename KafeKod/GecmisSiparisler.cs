using KafeKod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKod
{
    public partial class GecmisSiparisler : Form
    {
        KafeContext db;
        public GecmisSiparisler(KafeContext kafeVeri)
        {
            db = kafeVeri;
            InitializeComponent();

            dgvSiparisDetaylari.DataSource = db.Siparisler.Where(x => x.Durum != SiparisDurum.Aktif).ToList(); ;
        }

        private void dgvSiparisDetaylari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count >0)
            {
                DataGridViewRow satir = dgvSiparisler.SelectedRows[0];
                Siparis siparis = (Siparis)satir.DataBoundItem;
                dgvSiparisDetaylari.DataSource = siparis.SiparisDetaylar;
            }
        }
    }
}
