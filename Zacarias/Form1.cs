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
    public partial class Form1 : Form
    {
        string[] Person = new string[5];
        Form2 disp = new Form2();
        int Age;
        MyLogs log = new MyLogs();

        public Form1()
        {
            InitializeComponent();
            
        }


        public void LoadData(int index, string name, string gender, string hobby, string color, string saying)
        {
            selectedIndex = index;
            txtName.Text = name;

            rdbMale.Checked = gender == "Male";
            rdbFemale.Checked = gender == "Female";

            chkBasketball.Checked = hobby.Contains("Basketball");
            chkVolleyball.Checked = hobby.Contains("Volleyball");
            chkSoccer.Checked = hobby.Contains("Soccer");

            cmbFavC.SelectedItem = color;
            txtSaying.Text = saying;

            btnAdd.Visible = false;
            btnUpdate.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int i = 0;
            string data = "", gender = "", hobbies = "";
            data += txtName.Text;
            if (rdbMale.Checked)
            {
                gender = rdbMale.Text;
                data += gender;
            }
            else if (rdbFemale.Checked)
            {
                gender = rdbFemale.Text;
                data += gender;
            }
            data += lblAddress.Text;
            data += txtEmail.Text;
            data += dtpBday.Value;
            data += Age.ToString();
            if (chkBball.Checked)
            {
                hobbies += chkBball.Text + ", ";
            }
            if (chkVball.Checked)
            {
                hobbies += chkVball.Text + ", ";
            }
            if (chkSoccer.Checked)
            {
                hobbies += chkSoccer.Text;
            }
            data += hobbies;
            data += cbxColor.Text;
            data += txtSaying.Text;
            data += txtUser.Text;
            string password = txtPass.Text;
            Person[i] = data;
            MessageBox.Show("Succesfully Added!");
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop");
            Worksheet sheets = workbook.Worksheets[0];
            int row = sheets.Rows.Length + 1;
            sheets.Range[row, 1].Value = txtName.Text;
            sheets.Range[row, 2].Value = gender;
            sheets.Range[row, 3].Value = lblAddress.Text;
            sheets.Range[row, 4].Value = txtEmail.Text;
            sheets.Range[row, 5].Value = dtpBday.Text;
            sheets.Range[row, 6].Value = Age.ToString();
            sheets.Range[row, 7].Value = hobbies;
            sheets.Range[row, 8].Value = cbxColor.Text;
            sheets.Range[row, 9].Value = txtSaying.Text;
            sheets.Range[row, 10].Value = txtUser.Text;
            sheets.Range[row, 11].Value = password;
            sheets.Range[row, 13].Value = txtProfilePic.Text;
            workbook.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\bjeeeeccccccc\EVEDRI-Database.xlsx", ExcelVersion.Version2016);
            DataTable dt = sheets.ExportDataTable();
            disp.dataGridView1.DataSource = dt;
            log.InsertLogs(lbluserDis.Text, lbluserDis + " added a new record");
            i++;
        }

            if (i < 5)
            {
                names[i] = txtName.Text;
                genders[i] = rdbMale.Checked ? "Male" : "Female";

                // Use a list for hobbies to ensure proper formatting
                List<string> selectedHobbies = new List<string>();
                if (chkBasketball.Checked) selectedHobbies.Add("Basketball");
                if (chkVolleyball.Checked) selectedHobbies.Add("Volleyball");
                if (chkSoccer.Checked) selectedHobbies.Add("Soccer");

                hobbies[i] = selectedHobbies.Count > 0 ? string.Join(", ", selectedHobbies) : "None";

                colors[i] = cmbFavC.SelectedItem?.ToString() ?? "None";
                sayings[i] = txtSaying.Text;

                i++;

                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Too much data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear input fields
            txtName.Clear();
            rdbMale.Checked = rdbFemale.Checked = false;
            chkBasketball.Checked = chkVolleyball.Checked = chkSoccer.Checked = false;
            cmbFavC.SelectedIndex = -1; // Properly resets combo box
            txtSaying.Clear();
        }
        

        private void btnDisplay_Click(object sender, EventArgs e)
        {


            Form2 form2 = new Form2(this, names, genders, hobbies, colors, sayings, i);
            form2.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < i)
            {
                names[selectedIndex] = txtName.Text;
                genders[selectedIndex] = rdbMale.Checked ? "Male" : "Female";

                hobbies[selectedIndex] = "";
                if (chkBasketball.Checked) hobbies[selectedIndex] += "Basketball ";
                if (chkVolleyball.Checked) hobbies[selectedIndex] += "Volleyball ";
                if (chkSoccer.Checked) hobbies[selectedIndex] += "Soccer";
                hobbies[selectedIndex] = hobbies[selectedIndex].Trim();

                colors[selectedIndex] = cmbFavC.SelectedItem?.ToString() ?? "None";
                sayings[selectedIndex] = txtSaying.Text;

                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Invalid selection");
            }

            txtName.Text = string.Empty;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            chkBasketball.Checked = false;
            chkVolleyball.Checked = false;
            chkSoccer.Checked = false;
            cmbFavC.Text = "";
            txtSaying.Text = string.Empty;
        }

        
    }
    }

        
    
