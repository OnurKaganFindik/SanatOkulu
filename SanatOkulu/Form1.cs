using SanatOkulu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatOkulu
{
    public partial class Form1 : Form
    {
        SanatOkuluContext db = new SanatOkuluContext();
        public Form1()
        {
            InitializeComponent();
            SanatcilariYukle();
            EserleriListele();
            
        }

        private void SanatcilariYukle()
        {
            cboSanatci.DataSource = db.Sanatcilar.OrderBy(x => x.Ad).ToList();
            cboSanatci.ValueMember = "Id";
            cboSanatci.DisplayMember = "Ad";
        }

        private void pboYeniSanatci_Click(object sender, EventArgs e)
        {
            var frm = new SanatciForm(db);
            if (DialogResult.OK==frm.ShowDialog())
            {
                SanatcilariYukle();
            }
            frm.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            if (ad=="")
            {
                MessageBox.Show("Lütfen eserin adını belirtiniz.");
                return;
            }
            if (cboSanatci.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen bir sanatçı seçiniz");
                return;
            }
            var eser = new Eser()
            {
                Ad = ad,
                SanatciId = (int)cboSanatci.SelectedValue,
                Yil = Convert.ToInt32(mtbYil.Text)
            };
            db.Eserler.Add(eser);
            db.SaveChanges();
            FormuResetle();
            EserleriListele();
        }

        private void EserleriListele()
        {
            lvwEserler.Items.Clear();

            foreach (Eser eser in db.Eserler)
            {
                ListViewItem lvi = new ListViewItem(eser.Ad);
                lvi.SubItems.Add(eser.Sanatci.Ad);
                lvi.SubItems.Add(eser.Yil.ToString());
                lvwEserler.Items.Add(lvi);
            }
        }

        private void FormuResetle()
        {
            txtAd.Clear();
            mtbYil.Clear();
            cboSanatci.SelectedIndex = -1;
            txtAd.Focus();
        }
    }
}
