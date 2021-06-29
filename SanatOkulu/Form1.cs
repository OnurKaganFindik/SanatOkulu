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
            cboSanatci.SelectedIndex = -1;
        }

        private void pboYeniSanatci_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }

         void SanatciFormuAc()
        {
            var frm = new SanatciForm(db);
            frm.SanatcilarDegisti += Frm_SanatcilarDegisti;
            frm.ShowDialog();
        }
        private void Frm_SanatcilarDegisti(object sender, EventArgs e)
        {
            EserleriListele();
            SanatcilariYukle();
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
                Yil =mtbYil.Text==""?null as int?: Convert.ToInt32(mtbYil.Text)
            };
            db.Eserler.Add(eser);
            db.SaveChanges();
            FormuResetle();
            EserleriListele();
        }

        private void EserleriListele()
        {
            lvwEserler.Items.Clear();

            foreach (Eser eser in db.Eserler.OrderBy(x=>x.Yil))
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

        private void tsmiSanatcilar_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }
    }
}
