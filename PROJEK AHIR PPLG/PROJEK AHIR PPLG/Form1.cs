namespace PROJEK_AHIR_PPLG
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lblUsename_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //username dan password yang benar
            string usernametrue = "admin";
            string passwordtrue = "558";

            //Mengambil Input dari user
            string usernameInput = txtUsername.Text;
            string passwordInput = txtPasword.Text;

            //validasi Login
            if (usernameInput == usernametrue && passwordInput == passwordtrue)
            {
                // jika login Berhasil
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Membuka Transaksi
                FormTransaksi formTransaksi = new FormTransaksi();
                formTransaksi.Show();

                // Menyembunyikan Form Login (bukan menutup, agar aplikasi tidak berhenti)
                this.Hide();
            }
            else
            {
                // Jika Login gagal
                MessageBox.Show("Username atau Password salah!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Membersihkan field password
                txtPasword.Clear();
                txtPasword.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
