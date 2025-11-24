namespace PROJEK_AHIR_PPLG
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            lblNamaPE = new Label();
            txtNamaPE = new TextBox();
            lblMakanan = new Label();
            cmbMakanan = new ComboBox();
            cmbMinuman = new ComboBox();
            btnPesan = new Button();
            btnBatal = new Button();
            dvgdata = new DataGridView();
            label3 = new Label();
            lblMinuman = new Label();
            lblPembayaran = new Label();
            cmbPembayaran = new ComboBox();
            lblNoP = new Label();
            btnRiw = new Button();
            listB = new ListBox();
            lblT = new Label();
            txtT = new TextBox();
            cmbPed = new ComboBox();
            cmbSu = new ComboBox();
            btnBayar = new Button();
            lblTotal = new Label();
            lblBayar = new Label();
            label4 = new Label();
            lblKembalian = new Label();
            label6 = new Label();
            txttotalbayar = new TextBox();
            cmbMeja = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNamaPE
            // 
            lblNamaPE.AutoSize = true;
            lblNamaPE.BackColor = Color.Transparent;
            lblNamaPE.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNamaPE.Location = new Point(12, 112);
            lblNamaPE.Name = "lblNamaPE";
            lblNamaPE.Size = new Size(140, 20);
            lblNamaPE.TabIndex = 0;
            lblNamaPE.Text = "NAMA PEMESAN";
            // 
            // txtNamaPE
            // 
            txtNamaPE.Location = new Point(158, 105);
            txtNamaPE.Name = "txtNamaPE";
            txtNamaPE.Size = new Size(125, 27);
            txtNamaPE.TabIndex = 1;
            txtNamaPE.TextChanged += txtNamaPE_TextChanged;
            // 
            // lblMakanan
            // 
            lblMakanan.AutoSize = true;
            lblMakanan.BackColor = Color.Transparent;
            lblMakanan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMakanan.Location = new Point(12, 209);
            lblMakanan.Name = "lblMakanan";
            lblMakanan.Size = new Size(92, 20);
            lblMakanan.TabIndex = 2;
            lblMakanan.Text = "MAKANAN";
            // 
            // cmbMakanan
            // 
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Location = new Point(158, 201);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(151, 28);
            cmbMakanan.TabIndex = 3;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(158, 281);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(151, 28);
            cmbMinuman.TabIndex = 4;
            // 
            // btnPesan
            // 
            btnPesan.Location = new Point(39, 363);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(94, 29);
            btnPesan.TabIndex = 5;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(215, 363);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // dvgdata
            // 
            dvgdata.BackgroundColor = SystemColors.ButtonHighlight;
            dvgdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdata.Location = new Point(623, 105);
            dvgdata.Name = "dvgdata";
            dvgdata.RowHeadersWidth = 51;
            dvgdata.Size = new Size(679, 255);
            dvgdata.TabIndex = 7;
            dvgdata.CellContentClick += dvgdata_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(434, 9);
            label3.Name = "label3";
            label3.Size = new Size(302, 24);
            label3.TabIndex = 8;
            label3.Text = "WARUNG MAKAN BANG KAR";
            label3.Click += label3_Click;
            // 
            // lblMinuman
            // 
            lblMinuman.AutoSize = true;
            lblMinuman.BackColor = Color.Transparent;
            lblMinuman.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMinuman.Location = new Point(12, 281);
            lblMinuman.Name = "lblMinuman";
            lblMinuman.Size = new Size(92, 20);
            lblMinuman.TabIndex = 9;
            lblMinuman.Text = "MINUMAN";
            // 
            // lblPembayaran
            // 
            lblPembayaran.AutoSize = true;
            lblPembayaran.BackColor = Color.Transparent;
            lblPembayaran.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPembayaran.Location = new Point(385, 106);
            lblPembayaran.Name = "lblPembayaran";
            lblPembayaran.Size = new Size(125, 20);
            lblPembayaran.TabIndex = 10;
            lblPembayaran.Text = "PEMBAYARAN ";
            // 
            // cmbPembayaran
            // 
            cmbPembayaran.FormattingEnabled = true;
            cmbPembayaran.Location = new Point(385, 133);
            cmbPembayaran.Name = "cmbPembayaran";
            cmbPembayaran.Size = new Size(151, 28);
            cmbPembayaran.TabIndex = 11;
            // 
            // lblNoP
            // 
            lblNoP.AutoSize = true;
            lblNoP.BackColor = Color.Transparent;
            lblNoP.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNoP.Location = new Point(12, 159);
            lblNoP.Name = "lblNoP";
            lblNoP.Size = new Size(120, 20);
            lblNoP.TabIndex = 13;
            lblNoP.Text = "NOMOR MEJA";
            // 
            // btnRiw
            // 
            btnRiw.Location = new Point(1228, 456);
            btnRiw.Name = "btnRiw";
            btnRiw.Size = new Size(94, 29);
            btnRiw.TabIndex = 14;
            btnRiw.Text = "Riwayat";
            btnRiw.UseVisualStyleBackColor = true;
            btnRiw.Click += btnRiw_Click;
            // 
            // listB
            // 
            listB.FormattingEnabled = true;
            listB.Location = new Point(12, 453);
            listB.Name = "listB";
            listB.Size = new Size(336, 144);
            listB.TabIndex = 15;
            // 
            // lblT
            // 
            lblT.AutoSize = true;
            lblT.BackColor = Color.Transparent;
            lblT.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblT.Location = new Point(385, 182);
            lblT.Name = "lblT";
            lblT.Size = new Size(222, 20);
            lblT.TabIndex = 16;
            lblT.Text = "CATATAN ATAU TAMBAHAN";
            // 
            // txtT
            // 
            txtT.Location = new Point(385, 205);
            txtT.Name = "txtT";
            txtT.Size = new Size(125, 27);
            txtT.TabIndex = 17;
            // 
            // cmbPed
            // 
            cmbPed.FormattingEnabled = true;
            cmbPed.Location = new Point(158, 235);
            cmbPed.Name = "cmbPed";
            cmbPed.Size = new Size(151, 28);
            cmbPed.TabIndex = 19;
            // 
            // cmbSu
            // 
            cmbSu.FormattingEnabled = true;
            cmbSu.Location = new Point(158, 315);
            cmbSu.Name = "cmbSu";
            cmbSu.Size = new Size(151, 28);
            cmbSu.TabIndex = 21;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(889, 434);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(94, 29);
            btnBayar.TabIndex = 22;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(637, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 20);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total";
            // 
            // lblBayar
            // 
            lblBayar.AutoSize = true;
            lblBayar.BackColor = Color.Transparent;
            lblBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBayar.Location = new Point(637, 433);
            lblBayar.Name = "lblBayar";
            lblBayar.Size = new Size(90, 20);
            lblBayar.TabIndex = 24;
            lblBayar.Text = "Uang Bayar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(750, 402);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 25;
            label4.Click += label4_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.BackColor = Color.Transparent;
            lblKembalian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.Location = new Point(637, 402);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(83, 20);
            lblKembalian.TabIndex = 26;
            lblKembalian.Text = "Kembalian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(750, 372);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 27;
            // 
            // txttotalbayar
            // 
            txttotalbayar.Location = new Point(737, 434);
            txttotalbayar.Name = "txttotalbayar";
            txttotalbayar.Size = new Size(125, 27);
            txttotalbayar.TabIndex = 28;
            // 
            // cmbMeja
            // 
            cmbMeja.FormattingEnabled = true;
            cmbMeja.Location = new Point(158, 151);
            cmbMeja.Name = "cmbMeja";
            cmbMeja.Size = new Size(151, 28);
            cmbMeja.TabIndex = 29;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1208, 591);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 30;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1334, 609);
            Controls.Add(dataGridView1);
            Controls.Add(cmbMeja);
            Controls.Add(txttotalbayar);
            Controls.Add(label6);
            Controls.Add(lblKembalian);
            Controls.Add(label4);
            Controls.Add(lblBayar);
            Controls.Add(lblTotal);
            Controls.Add(btnBayar);
            Controls.Add(cmbSu);
            Controls.Add(cmbPed);
            Controls.Add(txtT);
            Controls.Add(lblT);
            Controls.Add(listB);
            Controls.Add(btnRiw);
            Controls.Add(lblNoP);
            Controls.Add(cmbPembayaran);
            Controls.Add(lblPembayaran);
            Controls.Add(lblMinuman);
            Controls.Add(label3);
            Controls.Add(dvgdata);
            Controls.Add(btnBatal);
            Controls.Add(btnPesan);
            Controls.Add(cmbMinuman);
            Controls.Add(cmbMakanan);
            Controls.Add(lblMakanan);
            Controls.Add(txtNamaPE);
            Controls.Add(lblNamaPE);
            Name = "FormTransaksi";
            Text = "Form2";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dvgdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaPE;
        private TextBox txtNamaPE;
        private Label lblMakanan;
        private ComboBox cmbMakanan;
        private ComboBox cmbMinuman;
        private Button btnPesan;
        private Button btnBatal;
        private DataGridView dvgdata;
        private Label label3;
        private Label lblMinuman;
        private Label lblPembayaran;
        private ComboBox cmbPembayaran;
        private Label lblNoP;
        private Button btnRiw;
        private ListBox listB;
        private Label lblT;
        private TextBox txtT;
        private Label lblRasa;
        private ComboBox cmbPed;
        private ComboBox cmbSu;
        private Button btnBayar;
        private Label lblTotal;
        private Label lblBayar;
        private Label label4;
        private Label lblKembalian;
        private Label label6;
        private TextBox txttotalbayar;
        private ComboBox cmbMeja;
        private DataGridView dataGridView1;
    }
}