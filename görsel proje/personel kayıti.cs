using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace görsel_proje
{
    public partial class personel_kayıti : Form
    {
        public personel_kayıti()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into personel(pKadi,pSifre) values (@pkadi,@psifre)", sqlconnection.connection);

            sqlconnection.CheckConnection();

            komut.Parameters.AddWithValue("@pkadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@psifre", txtsifre.Text);
            
            komut.ExecuteNonQuery();

            sqlconnection.connection.Close();
            MessageBox.Show("Personel Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
