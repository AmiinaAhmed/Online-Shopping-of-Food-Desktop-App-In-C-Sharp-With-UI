namespace FoodAppTest
{
    partial class AboutUsShowUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsShowUserControl));
            this.pnlAboutUs = new System.Windows.Forms.Panel();
            this.lblDesAboutUs = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.picBoxAboutUs = new System.Windows.Forms.PictureBox();
            this.pnlAboutUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAboutUs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAboutUs
            // 
            this.pnlAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAboutUs.Controls.Add(this.picBoxAboutUs);
            this.pnlAboutUs.Controls.Add(this.lblDesAboutUs);
            this.pnlAboutUs.Location = new System.Drawing.Point(48, 137);
            this.pnlAboutUs.Name = "pnlAboutUs";
            this.pnlAboutUs.Size = new System.Drawing.Size(690, 378);
            this.pnlAboutUs.TabIndex = 3;
            // 
            // lblDesAboutUs
            // 
            this.lblDesAboutUs.AutoSize = true;
            this.lblDesAboutUs.Font = new System.Drawing.Font("Curlz MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesAboutUs.Location = new System.Drawing.Point(6, 8);
            this.lblDesAboutUs.Name = "lblDesAboutUs";
            this.lblDesAboutUs.Size = new System.Drawing.Size(402, 360);
            this.lblDesAboutUs.TabIndex = 1;
            this.lblDesAboutUs.Text = resources.GetString("lblDesAboutUs.Text");
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(266, 30);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(257, 79);
            this.lblAboutUs.TabIndex = 2;
            this.lblAboutUs.Text = "About Us";
            // 
            // picBoxAboutUs
            // 
            this.picBoxAboutUs.BackgroundImage = global::FoodAppTest.Properties.Resources.Q_19;
            this.picBoxAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAboutUs.Location = new System.Drawing.Point(414, 8);
            this.picBoxAboutUs.Name = "picBoxAboutUs";
            this.picBoxAboutUs.Size = new System.Drawing.Size(254, 360);
            this.picBoxAboutUs.TabIndex = 2;
            this.picBoxAboutUs.TabStop = false;
            // 
            // AboutUsShowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAboutUs);
            this.Controls.Add(this.lblAboutUs);
            this.Name = "AboutUsShowUserControl";
            this.Size = new System.Drawing.Size(786, 545);
            this.pnlAboutUs.ResumeLayout(false);
            this.pnlAboutUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAboutUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAboutUs;
        private System.Windows.Forms.PictureBox picBoxAboutUs;
        private System.Windows.Forms.Label lblDesAboutUs;
        private System.Windows.Forms.Label lblAboutUs;
    }
}
