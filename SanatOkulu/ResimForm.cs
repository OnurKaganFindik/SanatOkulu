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
    public partial class ResimForm : Form
    {
        public ResimForm(string baslik,Image resim)
        {
            InitializeComponent();
            Text = baslik;
            pboResim.Image = resim;
        }
    }
}
