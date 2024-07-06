namespace DiyetDenemeUI
{
    partial class KarşılaştırmaRaporu
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
            btnGeri = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            yemekKategorisiToolStripMenuItem = new ToolStripMenuItem();
            yemekToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            yemekKategorisiToolStripMenuItem1 = new ToolStripMenuItem();
            yemekToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(11, 11);
            btnGeri.Margin = new Padding(2, 2, 2, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(101, 27);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 137);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(571, 291);
            dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(408, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { yemekKategorisiToolStripMenuItem, yemekToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(77, 24);
            toolStripMenuItem1.Text = "Haftalık";
            // 
            // yemekKategorisiToolStripMenuItem
            // 
            yemekKategorisiToolStripMenuItem.Name = "yemekKategorisiToolStripMenuItem";
            yemekKategorisiToolStripMenuItem.Size = new Size(206, 26);
            yemekKategorisiToolStripMenuItem.Text = "Yemek Kategorisi";
            yemekKategorisiToolStripMenuItem.Click += yemekKategorisiToolStripMenuItem_Click;
            // 
            // yemekToolStripMenuItem
            // 
            yemekToolStripMenuItem.Name = "yemekToolStripMenuItem";
            yemekToolStripMenuItem.Size = new Size(206, 26);
            yemekToolStripMenuItem.Text = "Yemek";
            yemekToolStripMenuItem.Click += yemekToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { yemekKategorisiToolStripMenuItem1, yemekToolStripMenuItem1 });
            toolStripMenuItem2.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(56, 24);
            toolStripMenuItem2.Text = "Aylık";
            // 
            // yemekKategorisiToolStripMenuItem1
            // 
            yemekKategorisiToolStripMenuItem1.Name = "yemekKategorisiToolStripMenuItem1";
            yemekKategorisiToolStripMenuItem1.Size = new Size(206, 26);
            yemekKategorisiToolStripMenuItem1.Text = "Yemek Kategorisi";
            yemekKategorisiToolStripMenuItem1.Click += yemekKategorisiToolStripMenuItem1_Click;
            // 
            // yemekToolStripMenuItem1
            // 
            yemekToolStripMenuItem1.Name = "yemekToolStripMenuItem1";
            yemekToolStripMenuItem1.Size = new Size(206, 26);
            yemekToolStripMenuItem1.Text = "Yemek";
            yemekToolStripMenuItem1.Click += yemekToolStripMenuItem1_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = SystemColors.ButtonFace;
            toolStripContainer1.ContentPanel.Margin = new Padding(2, 2, 2, 2);
            toolStripContainer1.ContentPanel.Size = new Size(408, 31);
            toolStripContainer1.Location = new Point(180, 10);
            toolStripContainer1.Margin = new Padding(2, 2, 2, 2);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(408, 59);
            toolStripContainer1.TabIndex = 5;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // KarşılaştırmaRaporu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._944fa48d9947de0fe9d3e428ec66e99e;
            ClientSize = new Size(682, 451);
            Controls.Add(toolStripContainer1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGeri);
            Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "KarşılaştırmaRaporu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KarşılaştırmaRaporu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGeri;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem yemekKategorisiToolStripMenuItem;
        private ToolStripMenuItem yemekToolStripMenuItem;
        private ToolStripMenuItem yemekKategorisiToolStripMenuItem1;
        private ToolStripMenuItem yemekToolStripMenuItem1;
        private ToolStripContainer toolStripContainer1;
    }
}