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
    public partial class Dashboard: Form
    {
            Workbook book = new Workbook();
            MyLogs logs = new MyLogs();
            LoginForm login = (LoginForm)Application.OpenForms["LoginForm"];
            public Dashboard()
            {
                InitializeComponent();
                lblActive.Text = ShowCount(12, "1").ToString();
                lblInactiveD.Text = ShowCount(12, "0").ToString();
                lblRedD.Text = ShowCount(8, "RED").ToString();
                lblOrangeD.Text = ShowCount(8, "ORANGE").ToString();
                lblYellowD.Text = ShowCount(8, "YELLOW").ToString();
                lblGreenD.Text = ShowCount(8, "GREEN").ToString();
                lblBlueD.Text = ShowCount(8, "BLUE").ToString();
                lblIndigoD.Text = ShowCount(8, "INDIGO").ToString();
                lblVioletD.Text = ShowCount(8, "VIOLET").ToString();
                lblBballD.Text = ShowCount(7, "BasketBall").ToString();
                lblVballD.Text = ShowCount(7, "VolleyBall").ToString();
                lblSoccerD.Text = ShowCount(7, "Soccer").ToString();
                lblMaleD.Text = ShowCount(2, "MALE").ToString();
                lblFemaleD.Text = ShowCount(2, "FEMALE").ToString();
                lblITd.Text = ShowCount(14, "BSIT").ToString();
                lblCSd.Text = ShowCount(14, "BSCS").ToString();
                lblISd.Text = ShowCount(14, "BSIS").ToString();
                lblCpEd.Text = ShowCount(14, "BSCpE").ToString();
                lblMMd.Text = ShowCount(14, "ACT-MM").ToString();
                lblADd.Text = ShowCount(14, "ACT-AD").ToString();
                LoadLogs();
                LoadActive();
            }
            public void userID(string ID)
            {
                lblNameVal.Text = ID;
            }
            public int ShowCount(int c, string v)
            {
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\bjeeeeccccccc\EVEDRI-Database.xlsx");
                Worksheet sh = book.Worksheets[0];
                int row = sh.Rows.Length;
                int counter = 0;
                for (int i = 2; i <= row; i++)
                {
                    string[] split = sh.Range[i, c].Value.Split(',');
                    if (split.Length > 0)
                    {
                        int pos = Array.IndexOf(split, v.Trim());
                        if (pos > -1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (sh.Range[i, c].Value == v)
                        {
                            counter++;
                        }
                    }
                }
                return counter;
            }
            private void btnLogOut_Click(object sender, EventArgs e)
            {
                logs.InsertLogs(lblID.Text, lblID.Text + " has logged out their account.");
                this.Close();
                LoginForm logIN = new LoginForm();
                logIN.Show();
            }
            private void btnActive_MouseMove(object sender, MouseEventArgs e)
            {
                btnActive.BackColor = Color.Black;
                btnActive.ForeColor = Color.White;
            }
            private void btnActive_MouseLeave(object sender, EventArgs e)
            {
                btnActive.BackColor = Color.White;
                btnActive.ForeColor = Color.Black;
            }
            private void lblLogs_Click(object sender, EventArgs e)
            {
                pnlLogs.BringToFront();
            }
            public void LoadLogs() //logs
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\bjeeeeccccccc\EVEDRI-Database.xlsx");
                Worksheet sheet = workbook.Worksheets[1];
                DataTable data = sheet.ExportDataTable();
                dgvLogs.DataSource = data;
            }
            public void LoadActive()
            {
            }
            private void btnActive_Click(object sender, EventArgs e)
            {
                pnlActiveStudents.BringToFront();
            }
        }
    }
