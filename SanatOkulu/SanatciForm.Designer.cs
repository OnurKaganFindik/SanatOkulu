
namespace SanatOkulu
{
    partial class SanatciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lstSanatcilar = new System.Windows.Forms.ListBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sanatçının Adı";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(223, 38);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(107, 46);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 26);
            this.txtAd.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(350, 38);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(107, 46);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(14, 380);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 46);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(138, 380);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(107, 46);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lstSanatcilar
            // 
            this.lstSanatcilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSanatcilar.FormattingEnabled = true;
            this.lstSanatcilar.ItemHeight = 20;
            this.lstSanatcilar.Location = new System.Drawing.Point(12, 97);
            this.lstSanatcilar.Name = "lstSanatcilar";
            this.lstSanatcilar.Size = new System.Drawing.Size(445, 264);
            this.lstSanatcilar.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(350, 380);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(107, 46);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // SanatciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 442);
            this.Controls.Add(this.lstSanatcilar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SanatciForm";
            this.Text = "Sanatçı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ListBox lstSanatcilar;
        private System.Windows.Forms.Button btnKapat;
    }
}