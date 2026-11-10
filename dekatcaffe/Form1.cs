using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace dekatcaffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            User user1 = new User() {
                Name = "Adit" , 
                pasword = "123" , 
                role = "Admin"
            };

           Console.WriteLine($"nama user 1 adalah : {user1.Name}");

            User user2 = new User()
            {
                Name = "Eko",
                pasword = "124",
                role = "Kasir"
            };

            Console.WriteLine($"Nama user 2 dalah : {user2.Name}");
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] username1 = { "Adit" ,"Eko" };
            string[] pasword1 = { "123","124" };

            bool jangkrik = false;
            for (int i = 0; i < username1.Length; i++) { 
                if (username.Text == username1[i] && pasword.Text == pasword1[i])
                { 
                    jangkrik = true; 

                }
            }
            if (username.Text == "Adit")
            {
                MessageBox.Show("berhasil");
                
                //buat object from nya 
                mastermenu formAdit = new mastermenu();
                //Tampilkan Formnya
                formAdit.Show();
                //form1 disembunyikan
                this.Hide();
            }
            else if (username.Text == "Eko")
            {
                MessageBox.Show("berhasil");
                //buat object from nya 
                Form3 formEko = new Form3();
                //Tampilkan Formnya
                formEko.Show();
                //form1 disembunyikan
                this.Hide();
            }
            else
            {
                MessageBox.Show("gagal");
            }
        }

        private void pasword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
