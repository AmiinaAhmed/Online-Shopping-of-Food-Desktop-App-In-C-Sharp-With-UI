namespace FoodAppTest
{
    partial class FoodieWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodieWelcome));
            this.lblWelcomeToFoodie = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGithubLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeToFoodie
            // 
            this.lblWelcomeToFoodie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeToFoodie.AutoSize = true;
            this.lblWelcomeToFoodie.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeToFoodie.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblWelcomeToFoodie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWelcomeToFoodie.Font = new System.Drawing.Font("Forte", 57F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeToFoodie.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWelcomeToFoodie.Location = new System.Drawing.Point(251, 340);
            this.lblWelcomeToFoodie.Name = "lblWelcomeToFoodie";
            this.lblWelcomeToFoodie.Size = new System.Drawing.Size(694, 83);
            this.lblWelcomeToFoodie.TabIndex = 4;
            this.lblWelcomeToFoodie.Text = "Welcome to FOoDiE";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkRed;
            this.btnStart.ImageKey = "(none)";
            this.btnStart.Location = new System.Drawing.Point(801, 443);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(133, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Go On";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGithubLink
            // 
            this.btnGithubLink.Image = global::FoodAppTest.Properties.Resources.Webp_net_resizeimage__8_;
            this.btnGithubLink.Location = new System.Drawing.Point(156, 350);
            this.btnGithubLink.Name = "btnGithubLink";
            this.btnGithubLink.Size = new System.Drawing.Size(89, 83);
            this.btnGithubLink.TabIndex = 5;
            this.btnGithubLink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGithubLink.UseVisualStyleBackColor = true;
            this.btnGithubLink.Click += new System.EventHandler(this.btnGithubLink_Click);
            // 
            // FoodieWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodAppTest.Properties.Resources.fast_food_and_space_on_bottom_23_2147695664;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.btnGithubLink);
            this.Controls.Add(this.lblWelcomeToFoodie);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodieWelcome";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_ToChange);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_ToChange);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeToFoodie;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGithubLink;
    }
}

