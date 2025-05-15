using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zacarias
{

    public partial class Form2 : Form
    {
        private Form1 parentForm;
        public Form2(Form1 form1, string[] names, string[] genders, string[] hobbies, string[] colors, string[] sayings, int count)

        {
            InitializeComponent();
            parentForm = form1;

            dtg1.Columns.Add("Name", "Name");
            dtg1.Columns.Add("Gender", "Gender");
            dtg1.Columns.Add("Hobbies", "Hobbies");
            dtg1.Columns.Add("Favorite Color", "Favorite Color");
            dtg1.Columns.Add("Saying", "Saying");

            for (int i = 0; i < count; i++)
            {
                dtg1.Rows.Add(names[i], genders[i], hobbies[i], colors[i], sayings[i]);
            }

        }

        public Form2()
        {
            InitializeComponent();
            LoadExcelFile();

        }
        private void LoadExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Book1.xlsx");

            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dtg1.DataSource = dt;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dtg1.SelectedRows)
            {
                dtg1.Rows.Remove(r);

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dtg1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 form1 = new Form1(this);

            int r = dataGridView1.CurrentCell.RowIndex;
            form1.lblID.Text = r.ToString();

            form1.txtName.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            form1.txtSaying.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            form1.cmbFavcolor.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            form1.txtUserName.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            form1.txtPassword.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
            form1.cmbCourses.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            form1.cmbStatus.Text = dataGridView1.Rows[r].Cells[10].Value.ToString();
            form1.txtEmail.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            form1.pictureBox1.ImageLocation = dataGridView1.Rows[r].Cells[11].Value.ToString();

            Workbook book = new Workbook();
            book.LoadFromFile(path.pathfile); //Change the path to where is the excel locate.
            Worksheet sheet = book.Worksheets[2];

            int rows = sheet.Rows.Length;

            DateTime parsedDate;

            for (int i = 2; i <= rows; i++)
            {
                if (dataGridView1.Rows[r].Cells[8].Value.ToString() == sheet.Range[i, 1].Value)
                {
                    if (DateTime.TryParse(sheet.Range[i, 2].Value, out parsedDate))
                    {
                        form1.dateTimePicker1.Value = parsedDate;
                    }
                }
            }


            switch (dataGridView1.Rows[r].Cells[1].Value)
            {
                case "Male":
                    form1.radMale.Checked = true;
                    break;
                default:
                    form1.radFemale.Checked = true;
                    break;
            }
            string cellValue = dataGridView1.Rows[r].Cells[2].Value?.ToString();
            if (!string.IsNullOrEmpty(cellValue))
            {
                string[] words = cellValue.Split(' '); // Split by space

                foreach (string word in words)
                {
                    if (word == "Basketball")
                    {
                        form1.chkBasketball.Checked = true;
                    }
                    if (word == "Volleyball")
                    {
                        form1.chkVolleyball.Checked = true;
                    }
                    if (word == "Online-Games")
                    {
                        form1.chkOG.Checked = true;
                    }
                    if (word == "Others.")
                    {
                        form1.chkOthers.Checked = true;
                    }
                }
            }

            this.Hide();
            form1.Show();
            form1.btnUpdate.Visible = true;
            form1.cmbStatus.Enabled = false;
            form1.dateTimePicker1.Enabled = false;
            form1.btnDisplay.Visible = false;
            form1.btnAdd.Visible = false;
        }
    }
}
