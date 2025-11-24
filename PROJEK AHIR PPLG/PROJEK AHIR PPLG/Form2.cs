using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROJEK_AHIR_PPLG
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            dvgdata.ColumnCount = 10;
            dvgdata.Columns[0].Name = "Nama Pembeli";
            dvgdata.Columns[1].Name = "Nomor Meja";
            dvgdata.Columns[2].Name = "Makanan";
            dvgdata.Columns[3].Name = "Rasa";
            dvgdata.Columns[4].Name = "Haraga";
            dvgdata.Columns[4].Name = "Minuman";
            dvgdata.Columns[5].Name = "Harga";
            dvgdata.Columns[5].Name = "Suhu";
            dvgdata.Columns[6].Name = "Metode Pembayaran";
            dvgdata.Columns[7].Name = "Catatan";
            dvgdata.Columns[8].Name = "Toal Harga";
            dvgdata.Columns[9].Name = "Kembalian";


            // Tambah Data Combobox
            cmbMeja.Items.Add("1");
            cmbMeja.Items.Add("2");
            cmbMeja.Items.Add("3");
            cmbMeja.Items.Add("4");
            cmbMeja.Items.Add("5");
            cmbMeja.Items.Add("6");
            cmbMeja.Items.Add("7");
            cmbMeja.Items.Add("8");
            cmbMeja.Items.Add("9");
            cmbMeja.Items.Add("10");

            cmbMakanan.Items.Add("Nasi Lele Goreng - Rp10.000");
            cmbMakanan.Items.Add("Nasi Ayam Goreng - Rp13.000");
            cmbMakanan.Items.Add("Nasi Bebek Goreng - Rp14.000");
            cmbMakanan.Items.Add("Nasi Ayam Bakar - Rp14.000");
            cmbMakanan.Items.Add("Nasi Gurame Bakar - Rp20.000");
            cmbMakanan.Items.Add("Nasi Bebek Bakar - Rp15.000");
            cmbMakanan.Items.Add("Nasi Nilai Goreng - Rp17.000");
            cmbMakanan.Items.Add("Sate Ayam - Rp10.000");
            cmbMakanan.Items.Add("Sate Kambing - Rp25.000");
            cmbMakanan.Items.Add("Mie Goreng - Rp5.000");

            cmbPed.Items.Add("Level 0");
            cmbPed.Items.Add("Level 1");
            cmbPed.Items.Add("Level 2");
            cmbPed.Items.Add("Level 3");
            cmbPed.Items.Add("Level 4");
            cmbPed.Items.Add("Level 5");

            cmbMinuman.Items.Add("Teh - Rp3.000");
            cmbMinuman.Items.Add("Jeruk - Rp4.000");
            cmbMinuman.Items.Add("Kopi - Rp3.000");
            cmbMinuman.Items.Add("Coklat - Rp10.000");
            cmbMinuman.Items.Add("Air Mineral - Rp3.000");
            cmbMinuman.Items.Add("Soda Gembira - Rp20.000");
            cmbMinuman.Items.Add("Susu Coklat - Rp30.000");
            cmbMinuman.Items.Add("Susu Vanilla - Rp35.000");
            cmbMinuman.Items.Add("jus Jeruk - Rp13.000");

            cmbSu.Items.Add("Dingin/ES");
            cmbSu.Items.Add("Hangat");
            cmbSu.Items.Add("Panas");

            cmbPembayaran.Items.Add("Cash");
            cmbPembayaran.Items.Add("OVO");
            cmbPembayaran.Items.Add("Gopay");
            cmbPembayaran.Items.Add("DANA");
            cmbPembayaran.Items.Add("Qris");
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

            string NamaPE = txtNamaPE.Text.Trim();
            string Meja = cmbMeja.SelectedItem?.ToString();
            string Makanan = cmbMakanan.SelectedItem?.ToString();
            string Rasa = cmbPed.SelectedItem?.ToString();
            string Minuman = cmbMinuman.SelectedItem?.ToString();
            string Suhu = cmbSu.SelectedItem?.ToString();
            string Pembayaran = cmbPembayaran.SelectedItem?.ToString();
            string Catatan = txtT.Text.Trim();
            int TotalHarga = 0;
            int kembalian = 0;

            if (NamaPE == "" || Meja == "" || Makanan == "" || Rasa == "" || Minuman == "" || Suhu == "" || Pembayaran == "" || Catatan == null)
            {
                MessageBox.Show("Nama Pembeli!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hitung Total Harga
            switch (Makanan)
            {
                case "nasi Lele Goreng - Rp10.000":
                    TotalHarga += 10000;
                    break;
                case "Nasi Ayam Goreng - Rp13.000":
                    TotalHarga += 13000;
                    break;
                case "Nasi Bebek Goreng - Rp14.000":
                    TotalHarga += 14000;
                    break;
                case "Nasi Ayam Bakar - Rp14.000":
                    TotalHarga += 14000;
                    break;
                case "Nasi Gurame Bakar - Rp20.000":
                    TotalHarga += 20000;
                    break;
                case "Nasi Bebek Bakar - Rp15.000":
                    TotalHarga += 15000;
                    break;
                case "Nasi Nilai Goreng - Rp17.000":
                    TotalHarga += 17000;
                    break;
                case "Sate Ayam - Rp10.000":
                    TotalHarga += 10000;
                    break;
                case "Sate Kambing - Rp25.000":
                    TotalHarga += 25000;
                    break;
                case "Mie Goreng - Rp5.000":
                    TotalHarga += 5000;
                    break;
            }
            switch (Minuman)
            {
                case "Teh - Rp3.000":
                    TotalHarga += 3000;
                    break;
                case "Jeruk - Rp4.000":
                    TotalHarga += 4000;
                    break;
                case "Kopi - Rp3.000":
                    TotalHarga += 3000;
                    break;
                case "Coklat - Rp10.000":
                    TotalHarga += 10000;
                    break;
                case "Air Mineral - Rp3.000":
                    TotalHarga += 3000;
                    break;
                case "Soda Gembira - Rp20.000":
                    TotalHarga += 20000;
                    break;
                case "Susu Coklat - Rp30.000":
                    TotalHarga += 30000;
                    break;
                case "Susu Vanilla - Rp35.000":
                    TotalHarga += 35000;
                    break;
                case "jus Jeruk - Rp13.000":
                    TotalHarga += 13000;
                    break;
            }
            // Tambah data ke DataGridView
            string[] row = { NamaPE, Makanan, Minuman, "Rp" + TotalHarga.ToString() };

            txtNamaPE.Clear();
            cmbMakanan.SelectedItem = null;
            cmbMinuman.SelectedItem = null;

            //menampilakn Total Harga
            dvgdata.Rows.Add(NamaPE, Meja, Makanan, Rasa, Minuman, Suhu, Pembayaran, Catatan, TotalHarga, kembalian);

            // Bersihkan input
            txtNamaPE.Clear();
            cmbMeja.SelectedIndex = -1;
            txtT.Clear();
            cmbMakanan.SelectedIndex = -1;
            cmbPed.SelectedIndex = -1;
            cmbMinuman.SelectedIndex = -1;
            cmbSu.SelectedIndex = -1;
            cmbPembayaran.SelectedIndex = -1;
            txtNamaPE.Focus();
            cmbMeja.SelectedItem?.ToString();
            txtT.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

            // Pastikan ada baris yang sedang dipilih
            if (dvgdata.CurrentRow != null)
            {
                // Hapus baris yang dipilih dari DataGridView
                int index = dvgdata.CurrentRow.Index;
                dvgdata.Rows.RemoveAt(index);
            }
            else
            {
                // Tampilkan pesan jika tidak ada baris yang dipilih
                MessageBox.Show(
                    "Pilih baris yang akan dihapus!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnRiw_Click(object sender, EventArgs e)
        {
            if (dvgdata.Rows.Count == 0 || dvgdata.Rows[0].IsNewRow)
            {
                MessageBox.Show("Tidak ada data untuk ditampilkan!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string daftar = "===========================================\n";
            daftar += "                             Riwayat Pesanan           \n";
            daftar += "============================================\n\n";

            // FOR LOOP untuk tampilkan daftar
            for (int i = 0; i < dvgdata.Rows.Count - 1; i++)
            {
                var row = dvgdata.Rows[i];
                daftar += $"{i + 1}. Nama: {row.Cells[0].Value} | Meja: {row.Cells[1].Value} | " +
                    $"Makanan: {row.Cells[2].Value} | Rasa: {row.Cells[3].Value} |" +
                    $" Minuman: {row.Cells[4].Value} | Suhu: {row.Cells[5].Value} |" +
                    $" Pembayaran: {row.Cells[6].Value} | Catatan: {row.Cells[7].Value}\n";
            }

            daftar += "\n===========================================\n";
            daftar += $"\nTotal Pesanan: {dvgdata.Rows.Count - 1}\n";

            MessageBox.Show(daftar, "Riwayat Pesanan");

        }

        private void dvgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnBayar_Click(object sender, EventArgs e)
        {
            int totalSemua = 0;
            int TotalHarga = 0;
            int total = totalSemua;

            // Input Uang Bayar
            string inputBayar = Microsoft.VisualBasic.Interaction.InputBox($"Total Bayar: Rp {total:N0}\nMasukkan uang bayar:\n\n\n❌Ingat jangan utang yaa!!!", "Pembayaran", "");
            if (inputBayar == "") return;

            // Validasi uang bayar
            if (!int.TryParse(inputBayar, out int uangBayar))
            {
                MessageBox.Show("Nominal tidak valid!", "Pembayaran");
                return;
            }

            // Cek cukup atau tidak
            if (uangBayar < total)
            {
                MessageBox.Show($"❌ Nahkan Uangnya kurang!\nKurang: Rp {(total - uangBayar):N0}");
                return;
            }

            int kembalian = uangBayar - total;
        }   
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaPE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
