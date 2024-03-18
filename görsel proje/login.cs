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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
             
            SqlCommand userlogin = new SqlCommand("select * from personel where pKadi=@pkadi and pSifre=@psifre",sqlconnection.connection);

            
            sqlconnection.CheckConnection();

            
            userlogin.Parameters.AddWithValue("@pkadi", txtkadi.Text);
            userlogin.Parameters.AddWithValue("@psifre", txtsifre.Text);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(userlogin);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
               
                MessageBox.Show("Hoş Geldiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               anasayfa frm = new anasayfa(); 
                frm.Show();
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("kullanıcı Adı veya Şifre Hatalı","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
