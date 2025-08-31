using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtnamahasil.Text = txtnama.Text;
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            // ? Validasi: cek semua input kosong, gabungkan pesan
            {
                //  Reset warna textbox dulu biar normal
                txtnama.BackColor = Color.White;
                txtabsen.BackColor = Color.White;
                txtpts.BackColor = Color.White;
                txtpas.BackColor = Color.White;

                // Validasi: cek semua input kosong, gabungkan pesan
                List<string> pesanError = new List<string>();

                if (string.IsNullOrWhiteSpace(txtnama.Text))
                {
                    pesanError.Add("Nama belum diisi");
                    txtnama.BackColor =Color.LightPink;
                }

                if (string.IsNullOrWhiteSpace(txtabsen.Text))
                {
                    pesanError.Add("Absen belum diisi");
                    txtabsen.BackColor = Color.LightPink;
                }

                if (string.IsNullOrWhiteSpace(txtpts.Text))
                {
                    pesanError.Add("Nilai PTS belum diisi");
                    txtpts.BackColor = Color.LightPink;
                }

                if (string.IsNullOrWhiteSpace(txtpas.Text))
                {
                    pesanError.Add("Nilai PAS belum diisi");
                    txtpas.BackColor = Color.LightPink;
                }

                // Kalau ada error, tampilkan sekaligus
                if (pesanError.Count > 0)
                {
                    string gabunganPesan = string.Join("\n", pesanError);
                    MessageBox.Show(gabunganPesan, "Peringatan",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // hentikan proses
                }

                string nama = txtnama.Text;
                string absen = txtabsen.Text;

                double pts, pas;

                //  Parsing angka dengan dukungan koma/titik
                if (!double.TryParse(txtpts.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out pts))
                {
                    MessageBox.Show("Nilai PTS tidak valid!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpts.BackColor = Color.LightPink;
                    txtpts.Focus();
                    return;
                }

                if (!double.TryParse(txtpas.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out pas))
                {
                    MessageBox.Show("Nilai PAS tidak valid!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpas.BackColor = Color.LightPink;
                    txtpas.Focus();
                    return;
                }

                //  Hitung rata-rata
                double rata = (pts + pas) / 2;

                //  Tentukan grade
                string grade;
                if (rata >= 85)
                    grade = "A";
                else if (rata >= 75)
                    grade = "B";
                else if (rata >= 65)
                    grade = "C";
                else if (rata >= 50)
                    grade = "D";
                else
                    grade = "E";

                //  Tampilkan hasil
                txtnamahasil.Text = nama;
                txtabsenhasil.Text = absen;
                txtratarata.Text = rata.ToString("0.00");
                txtgrade.Text = grade;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnama.Clear();
            txtabsen.Clear();
            txtpts.Clear();
            txtpas.Clear();
            txtnamahasil.Clear();
            txtabsenhasil.Clear();
            txtratarata.Clear();
            txtgrade.Clear();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnamahasil_TextChanged(object sender, EventArgs e)
        {
            txtnamahasil.Text = txtnama.Text;
        }

        private void txtabsenhasil_TextChanged(object sender, EventArgs e)
        {
            txtabsenhasil.Text = txtabsen.Text;
        }

        private void txtabsen_TextChanged(object sender, EventArgs e)
        {
            txtabsenhasil.Text = txtabsen.Text;
        }
    }
}
