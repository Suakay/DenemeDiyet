namespace DiyetDenemeUI
{
    partial class Yediklerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yediklerim));
            dtpTarih = new DateTimePicker();
            cmbYemek = new ComboBox();
            label1 = new Label();
            cmbYiyecekKategori = new ComboBox();
            label2 = new Label();
            cmbYiyecek = new ComboBox();
            nudOlcu = new NumericUpDown();
            label4 = new Label();
            dgwGoster = new DataGridView();
            pictureBox1 = new PictureBox();
            lblKullanici = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnGeri = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudOlcu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(274, 34);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(166, 23);
            dtpTarih.TabIndex = 0;
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(274, 87);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(166, 23);
            cmbYemek.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(274, 60);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 2;
            label1.Text = "Yemek";
            // 
            // cmbYiyecekKategori
            // 
            cmbYiyecekKategori.FormattingEnabled = true;
            cmbYiyecekKategori.Location = new Point(274, 140);
            cmbYiyecekKategori.Name = "cmbYiyecekKategori";
            cmbYiyecekKategori.Size = new Size(166, 23);
            cmbYiyecekKategori.TabIndex = 1;
            cmbYiyecekKategori.SelectedIndexChanged += cmbYiyecekKategori_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 113);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 2;
            label2.Text = "Yiyecek Kategorisi";
            // 
            // cmbYiyecek
            // 
            cmbYiyecek.FormattingEnabled = true;
            cmbYiyecek.Location = new Point(274, 193);
            cmbYiyecek.Name = "cmbYiyecek";
            cmbYiyecek.Size = new Size(166, 23);
            cmbYiyecek.TabIndex = 1;
            //cmbYiyecek.SelectedIndexChanged += cmbYiyecek_SelectedIndexChanged;
            // 
            // nudOlcu
            // 
            nudOlcu.Location = new Point(274, 245);
            nudOlcu.Name = "nudOlcu";
            nudOlcu.Size = new Size(166, 23);
            nudOlcu.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(274, 219);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 2;
            label4.Text = "Ölçü";
            // 
            // dgwGoster
            // 
            dgwGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGoster.Location = new Point(12, 288);
            dgwGoster.Name = "dgwGoster";
            dgwGoster.RowTemplate.Height = 25;
            dgwGoster.Size = new Size(859, 222);
            dgwGoster.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(670, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 103);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblKullanici
            // 
            lblKullanici.BackColor = Color.Transparent;
            lblKullanici.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullanici.Location = new Point(670, 34);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(119, 23);
            lblKullanici.TabIndex = 2;
            lblKullanici.Text = "Kullanıcı Adı";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 516);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(183, 61);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(344, 516);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(183, 61);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(688, 516);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(183, 61);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGeri
            // 
            btnGeri.AutoSize = true;
            btnGeri.BackColor = Color.Transparent;
            btnGeri.BackgroundImage = Properties.Resources.geridön;
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.ImageAlign = ContentAlignment.BottomLeft;
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(43, 37);
            btnGeri.TabIndex = 7;
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(274, 166);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 2;
            label3.Text = "Yiyecek";
            // 
            // Yediklerim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(883, 638);
            Controls.Add(btnGeri);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(pictureBox1);
            Controls.Add(dgwGoster);
            Controls.Add(nudOlcu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbYiyecek);
            Controls.Add(label2);
            Controls.Add(cmbYiyecekKategori);
            Controls.Add(lblKullanici);
            Controls.Add(label1);
            Controls.Add(cmbYemek);
            Controls.Add(dtpTarih);
            Name = "Yediklerim";
            Text = "Yediklerim";
            ((System.ComponentModel.ISupportInitialize)nudOlcu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwGoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTarih;
        private ComboBox cmbYemek;
        private Label label1;
        private ComboBox cmbYiyecekKategori;
        private Label label2;
        private ComboBox cmbYiyecek;
        private NumericUpDown nudOlcu;
        private Label label4;
        private DataGridView dgwGoster;
        private PictureBox pictureBox1;
        private Label lblKullanici;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnGeri;
        private Label label3;
    }
}