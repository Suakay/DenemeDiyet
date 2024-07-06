namespace DiyetDenemeUI
{
    partial class YemekSecimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekSecimi));
            dataGridView1 = new DataGridView();
            btnKahvalti = new Button();
            btnOgleYemegi = new Button();
            btnAksamYemegi = new Button();
            btnAraOgun = new Button();
            label1 = new Label();
            btnCikis = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(499, 296);
            dataGridView1.TabIndex = 0;
            // 
            // btnKahvalti
            // 
            btnKahvalti.BackColor = Color.Transparent;
            btnKahvalti.Location = new Point(12, 203);
            btnKahvalti.Name = "btnKahvalti";
            btnKahvalti.Size = new Size(150, 70);
            btnKahvalti.TabIndex = 1;
            btnKahvalti.Text = "Kahvaltı";
            btnKahvalti.UseVisualStyleBackColor = false;
            btnKahvalti.Click += btnKahvalti_Click;
            // 
            // btnOgleYemegi
            // 
            btnOgleYemegi.BackColor = Color.Transparent;
            btnOgleYemegi.Location = new Point(12, 277);
            btnOgleYemegi.Name = "btnOgleYemegi";
            btnOgleYemegi.Size = new Size(150, 70);
            btnOgleYemegi.TabIndex = 1;
            btnOgleYemegi.Text = "Öğle Yemeği";
            btnOgleYemegi.UseVisualStyleBackColor = false;
            btnOgleYemegi.Click += btnOgleYemegi_Click;
            // 
            // btnAksamYemegi
            // 
            btnAksamYemegi.Location = new Point(12, 353);
            btnAksamYemegi.Name = "btnAksamYemegi";
            btnAksamYemegi.Size = new Size(150, 70);
            btnAksamYemegi.TabIndex = 1;
            btnAksamYemegi.Text = "Akşam Yemeği";
            btnAksamYemegi.UseVisualStyleBackColor = true;
            btnAksamYemegi.Click += btnAksamYemegi_Click;
            // 
            // btnAraOgun
            // 
            btnAraOgun.Location = new Point(12, 429);
            btnAraOgun.Name = "btnAraOgun";
            btnAraOgun.Size = new Size(150, 70);
            btnAraOgun.TabIndex = 1;
            btnAraOgun.Text = "Ara Öğün";
            btnAraOgun.UseVisualStyleBackColor = true;
            btnAraOgun.Click += btnAraOgun_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(191, 11);
            label1.Name = "label1";
            label1.Size = new Size(343, 61);
            label1.TabIndex = 2;
            label1.Text = "Yemek Seçimleri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources.geridön;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(12, 11);
            btnCikis.Margin = new Padding(2);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(46, 36);
            btnCikis.TabIndex = 23;
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(80, 50);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(538, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // YemekSecimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(677, 510);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnCikis);
            Controls.Add(btnAraOgun);
            Controls.Add(btnAksamYemegi);
            Controls.Add(btnOgleYemegi);
            Controls.Add(btnKahvalti);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "YemekSecimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YemekSecimi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnKahvalti;
        private Button btnOgleYemegi;
        private Button btnAksamYemegi;
        private Button btnAraOgun;
        private Label label1;
        private Button btnCikis;
        private PictureBox pictureBox2;
    }
}