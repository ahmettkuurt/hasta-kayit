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
    public partial class hasta_ekle : Form
    {
        public hasta_ekle()
        {
            InitializeComponent();
        }

        private void hasta_ekle_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into hasta(hastaAdi,hastaSoyadi,hastaTc,hastaAdres) values (@pad,@psoyad,@ptc,@padres)", sqlconnection.connection);

            sqlconnection.CheckConnection();

            komut.Parameters.AddWithValue("@pad", txtad.Text);
            komut.Parameters.AddWithValue("@psoyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@ptc", txttc.Text);
            komut.Parameters.AddWithValue("@padres", txtadres.Text);

            komut.ExecuteNonQuery();

            sqlconnection.connection.Close();

            MessageBox.Show("Hasta Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
