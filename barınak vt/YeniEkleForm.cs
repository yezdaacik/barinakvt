using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barınak_vt
{
    public partial class YeniEkleForm : Form
    {
        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd=;";
        string yeniAd;
        public YeniEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "INSERT INTO hayvanlar  VALUES (NULL, @adi, @yas, @cins, @engel_durumu, @fotograf_adi);";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@adi", txtİsimEkle.Text);
                cmd.Parameters.AddWithValue("@yas", txtYasEkle.Text);
                cmd.Parameters.AddWithValue("@cins", cmbCinsEkle.SelectedValue);
                cmd.Parameters.AddWithValue("@engel_durumu", cbEngelDurumu.Checked);
                cmd.Parameters.AddWithValue("@fotograf_adi", "");

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                }
               
            }
        }

        private void YeniEkleForm_Load(object sender, EventArgs e)
        {
            string klasorYolu = @"poster";
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
            CmbDoldur();
        }

        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT cins FROM hayvanlar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbCinsEkle.DataSource = dt;

                cmbCinsEkle.DisplayMember = "cins";
                cmbCinsEkle.ValueMember = "cins";

            }

        }

        private void pbResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "poster", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbResimEkle.Image = null;

            if (File.Exists(hedefDosya))
            {
                pbResimEkle.Image = Image.FromFile(hedefDosya);
                pbResimEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
