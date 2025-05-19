namespace Zacarias
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 569);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(597, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 59);
            this.label2.TabIndex = 26;
            this.label2.Text = "DASHBOARD";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Zacarias.Properties.Resources.app;
            this.pictureBox5.Location = new System.Drawing.Point(11, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 66;
            this.pictureBox5.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(182, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 21);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(186, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(277, 82);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(120, 21);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "0";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(239, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(763, 185);
            this.panel6.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(239, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 185);
            this.panel2.TabIndex = 31;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Zacarias.Properties.Resources.pArts1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
    }
}