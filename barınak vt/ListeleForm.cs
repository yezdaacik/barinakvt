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
    public partial class ListeleForm : Form
    {
        string baglanti = "Server=localhost;Database=barinak;Uid=root;Pwd=;";
        string yeniAd="";
        public ListeleForm()
        {
            InitializeComponent();
        }

        void DgwDoldur()
        {

            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM hayvanlar;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwListele.DataSource = dt;
               
            }

        }

        private void ListeleForm_Load(object sender, EventArgs e)
        {
            string klasorYolu = @"poster";
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
            DgwDoldur();
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
                cmbCins.DataSource = dt;

                cmbCins.DisplayMember = "cins";
                cmbCins.ValueMember = "cins";

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgwListele.SelectedCells.Count > 0)
            {
                string sorgu = "UPDATE hayvanlar SET adi=@adi, yas = @yas, cins = @cins, engel_durumu=@durum, fotograf_adi= @fotograf  WHERE id = @id;";
                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@adi", txtİsim.Text);
                    cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                    cmd.Parameters.AddWithValue("@cins", cmbCins.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@durum", cbDurum.Checked);
                    cmd.Parameters.AddWithValue("@fotograf", yeniAd);

                    int id = Convert.ToInt32(dgwListele.SelectedRows[0].Cells["id"].Value);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwListele.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            string posterYol = Path.Combine(Environment.CurrentDirectory, "poster", dgwListele.SelectedRows[0].Cells["fotograf_adi"].Value.ToString());


            DialogResult cevap = MessageBox.Show("hayvanı silmek istediğinizden emin misiniz?",
                                                 "hayvanı sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);


            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int film_id = Convert.ToInt32(dgwListele.SelectedRows[0].Cells["id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM hayvanlar WHERE id=@id;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();


                    if (File.Exists(posterYol))
                    {

                        File.Delete(posterYol);
                    }
                    DgwDoldur();
                }
            }
        }

        private void dgwListele_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwListele.SelectedRows.Count > 0)
            {
                txtYas.Text = dgwListele.SelectedRows[0].Cells["yas"].Value.ToString();
                txtİsim.Text = dgwListele.SelectedRows[0].Cells["adi"].Value.ToString();              
                cbDurum.Checked = Convert.ToBoolean(dgwListele.SelectedRows[0].Cells["engel_durumu"].Value);             

                cmbCins.SelectedValue = dgwListele.SelectedRows[0].Cells["cins"].Value.ToString();

                string dosyaYolu = Path.Combine(Environment.CurrentDirectory, "poster", dgwListele.SelectedRows[0].Cells["fotograf_adi"].Value.ToString());

                pbResim.ImageLocation = null;

                if (File.Exists(dosyaYolu))
                {
                    pbResim.ImageLocation = dosyaYolu;
                    pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "poster", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbResim.Image = null;

            if (File.Exists(hedefDosya))
            {
                pbResim.Image = Image.FromFile(hedefDosya);
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
