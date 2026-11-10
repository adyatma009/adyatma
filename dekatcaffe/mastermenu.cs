using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekatcaffe
{
    public partial class mastermenu : Form
    {
        private List<menu> DaftarMenu = new List<menu>()
        {
            new menu {Id =new Guid(), nama = "Nasi Uduk", kategori = "maknan", harga = 10000, stok = 50},
            new menu {Id =new Guid(), nama = "Nasi Megono", kategori = "maknan", harga = 5000, stok = 70},
            new menu {Id =new Guid(), nama = "Nasi Kucing", kategori = "maknan", harga = 7000, stok = 90},
            new menu {Id =new Guid(), nama = "Nasi Ayam", kategori = "maknan", harga = 15000, stok = 56}
        };

        private int selectedIndex = -1;

        public mastermenu()
        {
            InitializeComponent();

            dgv1.Columns.Add("colNama", "Nama");
            dgv1.Columns.Add("colKategori", "Kategori");
            dgv1.Columns.Add("colHarga", "Harga");
            dgv1.Columns.Add("colStok", "Stok");

            TampilkanMenu();
        }

        //digunakan untukmenampilkan data dari daftar menu ke dalam dvg 
        private void TampilkanMenu()
        {


            foreach (menu menu in DaftarMenu)
            {
                dgv1.Rows.Add(menu.nama, menu.kategori, menu.harga, menu.stok);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            // mengambil data dari textbox

            var nama = txtnama.Text;
            var kategori = txtkategori.Text;
            var harga = Int32.Parse(txtharga.Text);
            var stok = Int32.Parse(txtstok.Text);

            // validasi memastikan input data tidak ada yang ksong seblum diproses 
            if (nama == "" || kategori == "" || harga == 0 || stok == 0)
            {
                MessageBox.Show("Periksa Data Anda, Menu Belum Tersimpan!");
                return;
            }

            // menambhankan menu menggunakan inputan 
            menu MenuBaru = new menu() { Id = new Guid(), nama = nama, kategori = kategori, harga = harga, stok = stok };

            //menyimpan menu baru kedalam atribut daftar menu
            DaftarMenu.Add(MenuBaru);

            // menampilkan ulang daftar menu yang sudah diperbarui
            TampilkanMenu();
            ClearFrom();
        }

        private void ClearFrom()
        {
            txtnama.Text = "";
            txtkategori.Text = "";
            txtharga.Text = "";
            txtstok.Text = "";
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var indexTarget = e.RowIndex;
            selectedIndex = indexTarget;

            var MenuDipilih = DaftarMenu[indexTarget];

            MessageBox.Show($"Data menu yang diambil adalah {MenuDipilih.nama}");

            txtnama.Text = MenuDipilih.nama;
            txtharga.Text = MenuDipilih.harga.ToString();
            txtkategori.Text = MenuDipilih.kategori;
            txtstok.Text = MenuDipilih.stok.ToString();

            txtnama.Enabled = true;
            txtharga.Enabled = true;
            txtkategori.Enabled = true;
            txtstok.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtnama.Enabled = false;
            txtharga.Enabled = false;
            txtkategori.Enabled = false;
            txtstok.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //DaftarMenu[index] = yang baru 
            DaftarMenu[selectedIndex] = new menu()
            {
                nama = txtnama.Text,
                kategori = txtkategori.Text,
                harga = Int32.Parse(txtharga.Text),
                stok = Int32.Parse(txtstok.Text)
            };

            TampilkanMenu();

            ClearFrom();  
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                var isConfrim = MessageBox.Show("Apakah anda yakin ingin menghapus data menu ?", "Confrim delete", MessageBoxButtons.YesNo);
                if (isConfrim == DialogResult.Yes)
                {
                    DaftarMenu.RemoveAt(selectedIndex);

                    TampilkanMenu();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFrom();
            txtnama.Enabled = false;
            txtharga.Enabled = false;
            txtkategori.Enabled = false;
            txtstok.Enabled = false;
            selectedIndex = -1;
        }
    }
}