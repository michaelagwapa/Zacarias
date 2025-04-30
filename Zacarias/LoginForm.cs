using Spire.Xls;
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
    public partial class LoginForm : Form
    {
        MyLogs logs = new MyLogs(); //referencing
        Dashboard dashB = (Dashboard)Application.OpenForms["DashBoard"];
        Dashboard dash = new Dashboard();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            
           
                Workbook book = new Workbook();
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book1.xlsx");

                Worksheet sheet = book.Worksheets[0];
                int Length = sheet.Rows.Length;
                bool log = false;
                for (int i = 2; i <= Length; i++)
                {
                    if (sheet.Range[i, 10].Value == txtUName.Text && sheet.Range[i, 11].Value == txtPass.Text)
                    {
                        log = true;
                        break;
                    }
                    else
                    {
                        log = false;
                    }
                }
                if (log == true)
                {
                    logs.InsertLogs(txtUName.Text, txtUName.Text + " logged in successfully!");
                    //dash.pbxProfileP.Image = Image.FromFile(@"" + sheet.Range[Length, 13]);
                    lblUName.Text = txtUName.Text.ToString();
                    dash.user(lbluDis.Text);
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data can't be found.");
                }



            }
         }
    }
