namespace DiyetDenemeUI
{
    partial class Alınan_Kaloriler
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGeri = new Button();
            btnHesapla2 = new Button();
            dataGridView1 = new DataGridView();
            nmrOlcu = new NumericUpDown();
            lblölçü = new Label();
            cmbYiyecek = new ComboBox();
            lblyiyecek = new Label();
            cmbkategori = new ComboBox();
            lblkategori = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrOlcu).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(139, 4);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(429, 151);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 120);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.BackgroundImage = Properties.Resources.geridön;
            btnGeri.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeri.Location = new Point(7, 6);
            btnGeri.Margin = new Padding(2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(46, 36);
            btnGeri.TabIndex = 20;
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click_1;
            // 
            // btnHesapla2
            // 
            btnHesapla2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla2.Location = new Point(198, 251);
            btnHesapla2.Margin = new Padding(2);
            btnHesapla2.Name = "btnHesapla2";
            btnHesapla2.Size = new Size(214, 45);
            btnHesapla2.TabIndex = 19;
            btnHesapla2.Text = "GÖSTER";
            btnHesapla2.UseVisualStyleBackColor = true;
            btnHesapla2.Click += btnHesapla2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 315);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(540, 180);
            dataGridView1.TabIndex = 18;
            // 
            // nmrOlcu
            // 
            nmrOlcu.Location = new Point(198, 218);
            nmrOlcu.Margin = new Padding(2);
            nmrOlcu.Name = "nmrOlcu";
            nmrOlcu.Size = new Size(214, 23);
            nmrOlcu.TabIndex = 17;
            // 
            // lblölçü
            // 
            lblölçü.AutoSize = true;
            lblölçü.BackColor = Color.Transparent;
            lblölçü.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblölçü.Location = new Point(7, 218);
            lblölçü.Margin = new Padding(2, 0, 2, 0);
            lblölçü.Name = "lblölçü";
            lblölçü.Size = new Size(45, 21);
            lblölçü.TabIndex = 16;
            lblölçü.Text = "Ölçü";
            // 
            // cmbYiyecek
            // 
            cmbYiyecek.FormattingEnabled = true;
            cmbYiyecek.Location = new Point(198, 184);
            cmbYiyecek.Margin = new Padding(2);
            cmbYiyecek.Name = "cmbYiyecek";
            cmbYiyecek.Size = new Size(216, 23);
            cmbYiyecek.TabIndex = 15;
            // 
            // lblyiyecek
            // 
            lblyiyecek.AutoSize = true;
            lblyiyecek.BackColor = Color.Transparent;
            lblyiyecek.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblyiyecek.Location = new Point(7, 184);
            lblyiyecek.Margin = new Padding(2, 0, 2, 0);
            lblyiyecek.Name = "lblyiyecek";
            lblyiyecek.Size = new Size(71, 21);
            lblyiyecek.TabIndex = 14;
            lblyiyecek.Text = "Yiyecek";
            // 
            // cmbkategori
            // 
            cmbkategori.BackColor = SystemColors.Window;
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Location = new Point(198, 151);
            cmbkategori.Margin = new Padding(2);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(216, 23);
            cmbkategori.TabIndex = 13;
            // 
            // lblkategori
            // 
            lblkategori.AutoSize = true;
            lblkategori.BackColor = Color.Transparent;
            lblkategori.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblkategori.Location = new Point(7, 149);
            lblkategori.Margin = new Padding(2, 0, 2, 0);
            lblkategori.Name = "lblkategori";
            lblkategori.Size = new Size(170, 21);
            lblkategori.TabIndex = 12;
            lblkategori.Text = "Yemek Kategorileri";
            // 
            // Alınan_Kaloriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            ClientSize = new Size(560, 497);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnGeri);
            Controls.Add(btnHesapla2);
            Controls.Add(dataGridView1);
            Controls.Add(nmrOlcu);
            Controls.Add(lblölçü);
            Controls.Add(cmbYiyecek);
            Controls.Add(lblyiyecek);
            Controls.Add(cmbkategori);
            Controls.Add(lblkategori);
            Margin = new Padding(2);
            Name = "Alınan_Kaloriler";
            Text = "Alınan_Kaloriler";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrOlcu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnhesapla;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGeri;
        private Button btnHesapla2;
        private DataGridView dataGridView1;
        private NumericUpDown nmrOlcu;
        private Label lblölçü;
        private ComboBox cmbYiyecek;
        private Label lblyiyecek;
        private ComboBox cmbkategori;
        private Label lblkategori;
    }
}