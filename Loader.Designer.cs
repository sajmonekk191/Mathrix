
namespace Grafy
{
    partial class Loader
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadlbl = new System.Windows.Forms.Label();
            this.proclbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grafy.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(113, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadlbl
            // 
            this.loadlbl.AutoSize = true;
            this.loadlbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadlbl.Location = new System.Drawing.Point(167, 210);
            this.loadlbl.Name = "loadlbl";
            this.loadlbl.Size = new System.Drawing.Size(71, 19);
            this.loadlbl.TabIndex = 1;
            this.loadlbl.Text = "Loading ...";
            // 
            // proclbl
            // 
            this.proclbl.AutoSize = true;
            this.proclbl.Location = new System.Drawing.Point(189, 163);
            this.proclbl.Name = "proclbl";
            this.proclbl.Size = new System.Drawing.Size(26, 15);
            this.proclbl.TabIndex = 2;
            this.proclbl.Text = "0 %";
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 238);
            this.Controls.Add(this.proclbl);
            this.Controls.Add(this.loadlbl);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loadlbl;
        private System.Windows.Forms.Label proclbl;
    }
}