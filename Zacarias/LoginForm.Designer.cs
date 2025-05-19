namespace Zacarias
{
    partial class Form3
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
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.choShowPsssword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUName
            // 
            this.txtUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(388, 195);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(271, 24);
            this.txtUName.TabIndex = 16;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.BackColor = System.Drawing.Color.Transparent;
            this.lblUName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUName.Location = new System.Drawing.Point(286, 195);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(96, 20);
            this.lblUName.TabIndex = 15;
            this.lblUName.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(388, 267);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(271, 24);
            this.txtPass.TabIndex = 18;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPass.Location = new System.Drawing.Point(289, 269);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(91, 20);
            this.lblPass.TabIndex = 17;
            this.lblPass.Text = "Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(429, 366);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(105, 36);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // choShowPsssword
            // 
            this.choShowPsssword.AutoSize = true;
            this.choShowPsssword.BackColor = System.Drawing.Color.Transparent;
            this.choShowPsssword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choShowPsssword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.choShowPsssword.Location = new System.Drawing.Point(512, 297);
            this.choShowPsssword.Name = "choShowPsssword";
            this.choShowPsssword.Size = new System.Drawing.Size(138, 21);
            this.choShowPsssword.TabIndex = 26;
            this.choShowPsssword.Text = "Show Password";
            this.choShowPsssword.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Zacarias.Properties.Resources.pArts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 535);
            this.Controls.Add(this.choShowPsssword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.lblUName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.CheckBox choShowPsssword;
    }
}