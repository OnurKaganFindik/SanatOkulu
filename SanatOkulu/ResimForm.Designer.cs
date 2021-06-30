
namespace SanatOkulu
{
    partial class ResimForm
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
            this.pboResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).BeginInit();
            this.SuspendLayout();
            // 
            // pboResim
            // 
            this.pboResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboResim.Location = new System.Drawing.Point(0, 0);
            this.pboResim.Name = "pboResim";
            this.pboResim.Size = new System.Drawing.Size(800, 450);
            this.pboResim.TabIndex = 0;
            this.pboResim.TabStop = false;
            // 
            // ResimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboResim);
            this.Name = "ResimForm";
            this.Text = "ResimForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboResim;
    }
}