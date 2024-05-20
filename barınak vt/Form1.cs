using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barınak_vt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniEkleForm yeniEkle = new YeniEkleForm();
            yeniEkle.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeleForm listele = new ListeleForm();
            listele.ShowDialog();
        }
    }
}
