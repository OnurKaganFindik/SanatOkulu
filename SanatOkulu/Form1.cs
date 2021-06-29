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

            if (ad == "")
            {
                MessageBox.Show("Lütfen eserini adını belirtiniz.");
                return;
            }

            if (cboSanatci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir sanatçı seçiniz.");
                return;
            }

            if (duzenlenen == null)
            {
                var eser = new Eser()
                {
                    Ad = ad,
                    SanatciId = (int)cboSanatci.SelectedValue,
                    Yil = mtbYil.Text == "" ? null as int? : Convert.ToInt32(mtbYil.Text)
                };
                db.Eserler.Add(eser);
            }
            else
            {
                duzenlenen.Ad = ad;
                duzenlenen.SanatciId = (int)cboSanatci.SelectedValue;
                duzenlenen.Yil = mtbYil.Text == "" ? null as int? : Convert.ToInt32(mtbYil.Text);
            }

            db.SaveChanges();
            FormuResetle();
            EserleriListele();
        }

        private void EserleriListele()
        {
            lvwEserler.Items.Clear();

            foreach (Eser eser in db.Eserler.OrderBy(x => x.Yil))
            {
                ListViewItem lvi = new ListViewItem(eser.Ad);
                lvi.SubItems.Add(eser.Sanatci.Ad);
                lvi.SubItems.Add(eser.Yil.ToString());
                lvi.Tag = eser;
                lvwEserler.Items.Add(lvi);
            }
        }

        private void FormuResetle()
        {
            txtAd.Clear();
            mtbYil.Clear();
            cboSanatci.SelectedIndex = -1;
            txtAd.Focus();
            duzenlenen = null;
            btnIptal.Hide();
            btnEkle.Text = "Ekle";
            lvwEserler.Enabled = true;
            txtAd.Focus();
        }

        private void tsmiSanatcilar_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }


        private void lvwEserler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvwEserler.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show(
                    "Seçili eseri silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    Eser eser = (Eser)lvwEserler.SelectedItems[0].Tag;
                    db.Eserler.Remove(eser);
                    db.SaveChanges();
                    EserleriListele();
                }
            }
        }
        Eser duzenlenen;
        private void lvwEserler_DoubleClick(object sender, EventArgs e)
        {
            var lvi = lvwEserler.SelectedItems[0];
           duzenlenen = (Eser)lvi.Tag;
            txtAd.Text = duzenlenen.Ad;
            cboSanatci.SelectedItem =duzenlenen.Sanatci;
            mtbYil.Text = duzenlenen.Yil.ToString();
            btnEkle.Text = "Kaydet";
            lvwEserler.Enabled = false;
            btnIptal.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormuResetle();

        }
    }
}
