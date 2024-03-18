using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görsel_proje
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void tbnhastakayit_Click(object sender, EventArgs e)
        {
            hasta_ekle frm = new hasta_ekle();
            frm.Show();
            
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            hastalar frm = new hastalar();
            frm.Show();
           
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            personel_kayıti frm = new personel_kayıti();
            frm.Show();
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
        }
    }
}
