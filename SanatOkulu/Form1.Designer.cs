﻿
namespace SanatOkulu
{
    partial class Form1
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
            if (disposing)
            {
               db.Dispose();
            }
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSanatci = new System.Windows.Forms.ComboBox();
            this.pboYeniSanatci = new System.Windows.Forms.PictureBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.mtbYil = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lvwEserler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSanatcilar = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.pboResim = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSanatci);
            this.groupBox1.Controls.Add(this.pboYeniSanatci);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.mtbYil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sanat Eseri";
            // 
            // cboSanatci
            // 
            this.cboSanatci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanatci.FormattingEnabled = true;
            this.cboSanatci.Location = new System.Drawing.Point(7, 126);
            this.cboSanatci.Name = "cboSanatci";
            this.cboSanatci.Size = new System.Drawing.Size(447, 28);
            this.cboSanatci.TabIndex = 4;
            // 
            // pboYeniSanatci
            // 
            this.pboYeniSanatci.BackgroundImage = global::SanatOkulu.Properties.Resources.plus;
            this.pboYeniSanatci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboYeniSanatci.Location = new System.Drawing.Point(465, 126);
            this.pboYeniSanatci.Name = "pboYeniSanatci";
            this.pboYeniSanatci.Size = new System.Drawing.Size(35, 28);
            this.pboYeniSanatci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboYeniSanatci.TabIndex = 3;
            this.pboYeniSanatci.TabStop = false;
            this.pboYeniSanatci.Click += new System.EventHandler(this.pboYeniSanatci_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(280, 191);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(97, 29);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(403, 191);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // mtbYil
            // 
            this.mtbYil.Location = new System.Drawing.Point(10, 193);
            this.mtbYil.Mask = "####";
            this.mtbYil.Name = "mtbYil";
            this.mtbYil.Size = new System.Drawing.Size(240, 26);
            this.mtbYil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yapıldığı Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sanatçısı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(10, 62);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(490, 26);
            this.txtAd.TabIndex = 1;
            // 
            // lvwEserler
            // 
            this.lvwEserler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwEserler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwEserler.HideSelection = false;
            this.lvwEserler.Location = new System.Drawing.Point(524, 35);
            this.lvwEserler.Name = "lvwEserler";
            this.lvwEserler.Size = new System.Drawing.Size(543, 592);
            this.lvwEserler.TabIndex = 2;
            this.lvwEserler.UseCompatibleStateImageBehavior = false;
            this.lvwEserler.View = System.Windows.Forms.View.Details;
            this.lvwEserler.DoubleClick += new System.EventHandler(this.lvwEserler_DoubleClick);
            this.lvwEserler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwEserler_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sanatçı";
            this.columnHeader2.Width = 258;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yıl";
            this.columnHeader3.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSanatcilar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSanatcilar
            // 
            this.tsmiSanatcilar.Name = "tsmiSanatcilar";
            this.tsmiSanatcilar.Size = new System.Drawing.Size(70, 20);
            this.tsmiSanatcilar.Text = "Sanatçılar";
            this.tsmiSanatcilar.Click += new System.EventHandler(this.tsmiSanatcilar_Click);
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            // 
            // pboResim
            // 
            this.pboResim.Location = new System.Drawing.Point(12, 257);
            this.pboResim.Name = "pboResim";
            this.pboResim.Size = new System.Drawing.Size(506, 375);
            this.pboResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboResim.TabIndex = 4;
            this.pboResim.TabStop = false;
            this.pboResim.Click += new System.EventHandler(this.pboResim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 644);
            this.Controls.Add(this.pboResim);
            this.Controls.Add(this.lvwEserler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sanat Okulu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pboYeniSanatci;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lvwEserler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cboSanatci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanatcilar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.PictureBox pboResim;
    }
}

