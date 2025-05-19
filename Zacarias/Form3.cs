using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zacarias
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Zacarias.Properties.Resources.app;
            this.pictureBox5.Location = new System.Drawing.Point(9, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 72);
            this.panel2.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 603);
            this.panel1.TabIndex = 67;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.dateTimePicker2);
            this.panel17.Controls.Add(this.lblName);
            this.panel17.Controls.Add(this.lblDate);
            this.panel17.Controls.Add(this.pictureBox6);
            this.panel17.Location = new System.Drawing.Point(-41, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1086, 72);
            this.panel17.TabIndex = 68;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(848, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(722, 38);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(120, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "0";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(272, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(212, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(54, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // Form3
            // 
            this.BackgroundImage = global::Zacarias.Properties.Resources.pArts2;
            this.ClientSize = new System.Drawing.Size(1046, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
