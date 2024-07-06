namespace DiyetDenemeUI
{
    partial class ParolayıGuncelle
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolayıGuncelle));
            button2 = new Button();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnGeriDon = new Button();
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtSifreTekrar = new TextBox();
            btnSıfreKurallari = new Button();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(640, 290);
            button2.Name = "button2";
            button2.Size = new Size(165, 42);
            button2.TabIndex = 19;
            button2.Text = "Parolayı Sıfırla";
            button2.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderRadius = 280;
            guna2GradientPanel1.Controls.Add(btnGeriDon);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(94, 148, 255);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 77, 165);
            guna2GradientPanel1.Location = new Point(-128, 4);
            guna2GradientPanel1.Margin = new Padding(2, 1, 2, 1);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(519, 455);
            guna2GradientPanel1.TabIndex = 20;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackgroundImage = Properties.Resources.geridön;
            btnGeriDon.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeriDon.Location = new Point(135, 2);
            btnGeriDon.Margin = new Padding(2, 2, 2, 2);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(46, 36);
            btnGeriDon.TabIndex = 22;
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 99);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(600, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 16;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(600, 185);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(206, 23);
            txtSifre.TabIndex = 17;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(462, 219);
            label3.Name = "label3";
            label3.Size = new Size(92, 33);
            label3.TabIndex = 14;
            label3.Text = "Şifreyi Onayla";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(561, 226);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 10;
            label6.Text = ":";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(463, 185);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 15;
            label2.Text = "Şifre";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(561, 182);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 11;
            label5.Text = ":";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(463, 147);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 12;
            label1.Text = "E-Mail";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(561, 144);
            label4.Name = "label4";
            label4.Size = new Size(27, 21);
            label4.TabIndex = 13;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(600, 225);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(206, 23);
            txtSifreTekrar.TabIndex = 18;
            // 
            // btnSıfreKurallari
            // 
            btnSıfreKurallari.Location = new Point(462, 290);
            btnSıfreKurallari.Name = "btnSıfreKurallari";
            btnSıfreKurallari.Size = new Size(165, 42);
            btnSıfreKurallari.TabIndex = 21;
            btnSıfreKurallari.Text = "Şifre Kuralları";
            btnSıfreKurallari.UseVisualStyleBackColor = true;
            btnSıfreKurallari.Click += btnSıfreKurallari_Click;
            // 
            // ParolayıGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 462);
            Controls.Add(button2);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(txtEmail);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtSifreTekrar);
            Controls.Add(btnSıfreKurallari);
            ImeMode = ImeMode.Katakana;
            Name = "ParolayıGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParolayıGuncelle";
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label4;
        private TextBox txtSifreTekrar;
        private Button btnSıfreKurallari;
        private Button btnGeriDon;
    }
}