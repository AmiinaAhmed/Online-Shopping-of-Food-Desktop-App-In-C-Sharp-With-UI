namespace FoodAppTest
{
    partial class HomeShowUserControl
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
            this.lblOnly = new System.Windows.Forms.Label();
            this.lblPriceOffer = new System.Windows.Forms.Label();
            this.lblNameOfOffer = new System.Windows.Forms.Label();
            this.lblDescOffer = new System.Windows.Forms.Label();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.picBoxHomeShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomeShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnly
            // 
            this.lblOnly.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.lblOnly.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblOnly.Location = new System.Drawing.Point(71, 115);
            this.lblOnly.Name = "lblOnly";
            this.lblOnly.Size = new System.Drawing.Size(56, 33);
            this.lblOnly.TabIndex = 11;
            this.lblOnly.Text = "Only";
            // 
            // lblPriceOffer
            // 
            this.lblPriceOffer.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceOffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.lblPriceOffer.Location = new System.Drawing.Point(113, 128);
            this.lblPriceOffer.Name = "lblPriceOffer";
            this.lblPriceOffer.Size = new System.Drawing.Size(174, 92);
            this.lblPriceOffer.TabIndex = 10;
            this.lblPriceOffer.Text = "$19";
            // 
            // lblNameOfOffer
            // 
            this.lblNameOfOffer.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameOfOffer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfOffer.ForeColor = System.Drawing.Color.Black;
            this.lblNameOfOffer.Location = new System.Drawing.Point(16, 230);
            this.lblNameOfOffer.Name = "lblNameOfOffer";
            this.lblNameOfOffer.Size = new System.Drawing.Size(245, 48);
            this.lblNameOfOffer.TabIndex = 9;
            this.lblNameOfOffer.Text = "Cheeseburger";
            this.lblNameOfOffer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescOffer
            // 
            this.lblDescOffer.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescOffer.Font = new System.Drawing.Font("Sitka Subheading", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescOffer.ForeColor = System.Drawing.Color.Black;
            this.lblDescOffer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDescOffer.Location = new System.Drawing.Point(6, 288);
            this.lblDescOffer.Name = "lblDescOffer";
            this.lblDescOffer.Size = new System.Drawing.Size(396, 122);
            this.lblDescOffer.TabIndex = 8;
            this.lblDescOffer.Text = "Mushroom , Lettuce , Ketchup \r\nChedder cheese  , Tomato , Onions And..\r\nYellow mu" +
    "stard  ,  American cheese\r\n \r\n     ";
            this.lblDescOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOrderNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.btnOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrderNow.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnOrderNow.Location = new System.Drawing.Point(129, 423);
            this.btnOrderNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(225, 41);
            this.btnOrderNow.TabIndex = 7;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            // 
            // picBoxHomeShow
            // 
            this.picBoxHomeShow.BackgroundImage = global::FoodAppTest.Properties.Resources.a;
            this.picBoxHomeShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxHomeShow.Location = new System.Drawing.Point(382, 136);
            this.picBoxHomeShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxHomeShow.Name = "picBoxHomeShow";
            this.picBoxHomeShow.Size = new System.Drawing.Size(386, 274);
            this.picBoxHomeShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHomeShow.TabIndex = 12;
            this.picBoxHomeShow.TabStop = false;
            // 
            // HomeShowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxHomeShow);
            this.Controls.Add(this.lblOnly);
            this.Controls.Add(this.lblPriceOffer);
            this.Controls.Add(this.lblNameOfOffer);
            this.Controls.Add(this.lblDescOffer);
            this.Controls.Add(this.btnOrderNow);
            this.Name = "HomeShowUserControl";
            this.Size = new System.Drawing.Size(786, 545);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomeShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHomeShow;
        private System.Windows.Forms.Label lblOnly;
        private System.Windows.Forms.Label lblPriceOffer;
        private System.Windows.Forms.Label lblNameOfOffer;
        private System.Windows.Forms.Label lblDescOffer;
        private System.Windows.Forms.Button btnOrderNow;
    }
}
