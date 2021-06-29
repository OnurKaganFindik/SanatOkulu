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
    public partial class SanatciForm : Form
    {
        private readonly SanatOkuluContext db;
        public SanatciForm(SanatOkuluContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad=="")
            {
                MessageBox.Show("Lütfen bir ad belirtiniz.");
                return;
            }
            db.Sanatcilar.Add(new Sanatci() { Ad = ad });
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
