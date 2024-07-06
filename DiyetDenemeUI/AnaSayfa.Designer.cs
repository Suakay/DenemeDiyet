namespace DiyetDenemeUI
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            gunSonuRaporuToolStripMenuItem = new ToolStripMenuItem();
            karsılastirmaRaporuToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            yemekSeçimiToolStripMenuItem = new ToolStripMenuItem();
            lblVucutIndeksi = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            lblBoy = new Label();
            label3 = new Label();
            lblAgirlik = new Label();
            label2 = new Label();
            label1 = new Label();
            lblUser = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, yemekSeçimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(655, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 22);
            toolStripMenuItem1.Text = "Kaç Kalori";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(74, 22);
            toolStripMenuItem2.Text = "Yediklerim";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { gunSonuRaporuToolStripMenuItem, karsılastirmaRaporuToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(63, 22);
            toolStripMenuItem3.Text = "Raporlar";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // gunSonuRaporuToolStripMenuItem
            // 
            gunSonuRaporuToolStripMenuItem.Name = "gunSonuRaporuToolStripMenuItem";
            gunSonuRaporuToolStripMenuItem.Size = new Size(182, 22);
            gunSonuRaporuToolStripMenuItem.Text = "Gun Sonu Raporu";
            gunSonuRaporuToolStripMenuItem.Click += gunSonuRaporuToolStripMenuItem_Click;
            // 
            // karsılastirmaRaporuToolStripMenuItem
            // 
            karsılastirmaRaporuToolStripMenuItem.Name = "karsılastirmaRaporuToolStripMenuItem";
            karsılastirmaRaporuToolStripMenuItem.Size = new Size(182, 22);
            karsılastirmaRaporuToolStripMenuItem.Text = "Karsılastirma Raporu";
            karsılastirmaRaporuToolStripMenuItem.Click += karsılastirmaRaporuToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(56, 22);
            toolStripMenuItem4.Text = "Ayarlar";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(44, 22);
            toolStripMenuItem5.Text = "Çıkış";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // yemekSeçimiToolStripMenuItem
            // 
            yemekSeçimiToolStripMenuItem.Name = "yemekSeçimiToolStripMenuItem";
            yemekSeçimiToolStripMenuItem.Size = new Size(89, 22);
            yemekSeçimiToolStripMenuItem.Text = "YemekSeçimi";
            yemekSeçimiToolStripMenuItem.Click += yemekSeçimiToolStripMenuItem_Click;
            // 
            // lblVucutIndeksi
            // 
            lblVucutIndeksi.BackColor = Color.Transparent;
            lblVucutIndeksi.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblVucutIndeksi.Location = new Point(204, 429);
            lblVucutIndeksi.Name = "lblVucutIndeksi";
            lblVucutIndeksi.Size = new Size(260, 69);
            lblVucutIndeksi.TabIndex = 7;
            lblVucutIndeksi.Text = "0.0";
            lblVucutIndeksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(59, 100);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(538, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(204, 368);
            label4.Name = "label4";
            label4.Size = new Size(260, 69);
            label4.TabIndex = 8;
            label4.Text = "Vücut Kitle Endeksi";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBoy
            // 
            lblBoy.BackColor = Color.Transparent;
            lblBoy.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblBoy.Location = new Point(337, 305);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(260, 69);
            lblBoy.TabIndex = 9;
            lblBoy.Text = "0.0";
            lblBoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 305);
            label3.Name = "label3";
            label3.Size = new Size(260, 69);
            label3.TabIndex = 10;
            label3.Text = "Boy";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgirlik
            // 
            lblAgirlik.BackColor = Color.Transparent;
            lblAgirlik.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgirlik.Location = new Point(337, 236);
            lblAgirlik.Name = "lblAgirlik";
            lblAgirlik.Size = new Size(260, 69);
            lblAgirlik.TabIndex = 11;
            lblAgirlik.Text = "0.0";
            lblAgirlik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 236);
            label2.Name = "label2";
            label2.Size = new Size(260, 69);
            label2.TabIndex = 12;
            label2.Text = "Ağırlık";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 498);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 14;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("MV Boli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(204, 490);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(260, 69);
            lblUser.TabIndex = 15;
            lblUser.Text = ".";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(655, 497);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(lblVucutIndeksi);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(lblBoy);
            Controls.Add(label3);
            Controls.Add(lblAgirlik);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private Label lblVucutIndeksi;
        private PictureBox pictureBox2;
        private Label label4;
        private Label lblBoy;
        private Label label3;
        private Label lblAgirlik;
        private Label label2;
        private ToolStripMenuItem gunSonuRaporuToolStripMenuItem;
        private ToolStripMenuItem karsılastirmaRaporuToolStripMenuItem;
        private Label label1;
        private Label lblUser;
        private ToolStripMenuItem yemekSeçimiToolStripMenuItem;
    }
}