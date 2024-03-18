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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }

        private void hastalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobilhastaDataSet.hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.mobilhastaDataSet.hasta);

        }
    }
}
