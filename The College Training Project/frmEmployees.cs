using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using The_College_Training_Project.Models;
using The_Connection.MiddleTierData;

namespace The_College_Training_Project
{
    public partial class frmEmployees : Form
    {

        public frmEmployees()
        {


            InitializeComponent();
        }

        MiddleTier Manager = new MiddleTier();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBDepartment.SelectedItem == null || cmbBxCollegeID.SelectedItem == null)
            {
                MessageBox.Show("Please Add a value");
                return;
            }
            bool Succesful = Manager.AddRegularEmployee(txtBEmployeesID.Text, txtBFirstName.Text, txtBLastName.Text, txtBSSN.Text, DateTime.Parse(txtBDateOfBirth.Text), cmbBxGender.Text, cmbBxMaritalStatus.Text, ((ComboboxItem)cmbBxCollegeID.SelectedItem).Value, DateTime.Parse(txtBHireDate.Text), ((ComboboxItem)cmbBDepartment.SelectedItem).Value, chckBxYesGym.Checked);


            if (Succesful == true)
            {
                MessageBox.Show("New Employee successfully added");
                dataGridVRegEmployees.DataSource = Manager.LoadRegularEmployees();
                clear();
            }

            else
            {
                MessageBox.Show("Failed to add new employee. Please try again");
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            labLID.Text = "";
            txtBEmployeesID.Text = "";
            txtBFirstName.Text = "";
            txtBLastName.Text = "";
            txtBSSN.Text = "";
            txtBDateOfBirth.Text = "";
            cmbBxCollegeID.SelectedItem = "";
            txtBHireDate.Text = "";
            cmbBxGender.SelectedItem = "";
            cmbBxMaritalStatus.SelectedItem = "";
            cmbBDepartment.SelectedItem = "";
            chckBxYesGym.Checked = true;

            StudentIDLabel.Text = "";
            textBStudentFirstName.Text = "";
            txtBStudentLastName.Text = "";
            txtBStudentSSN.Text = "";
            cmbBStudentGender.SelectedItem = "";
            txtBStudentDateOfBirth.Text = "";
            cmbBStudentMaritalStatus.SelectedItem = "";
            cmbBoxStudentColID.SelectedItem = "";
            txtBStartDate.Text = "";
            txtBAverageHoursWeekly.Text = "";
            chckBoxStudentYES.Checked = true;

        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            cmbBDepartment.DisplayMember = "Text";
            cmbBDepartment.ValueMember = "Value";

            ComboboxItem item = new ComboboxItem();
            item.Text = "IT";
            item.Value = 0;
            cmbBDepartment.Items.Add(item);
            item = new ComboboxItem();
            item.Text = "Underwriting";
            item.Value = 1;
            cmbBDepartment.Items.Add(item);
            item = new ComboboxItem();
            item.Text = "Claim";
            item.Value = 2;
            cmbBDepartment.Items.Add(item);
            item = new ComboboxItem();
            item.Text = "Business";
            item.Value = 3;
            cmbBDepartment.Items.Add(item);
            item = new ComboboxItem();
            item.Text = "Aministration";
            item.Value = 4;
            cmbBDepartment.Items.Add(item);

            List<College> colleges = Manager.LoadColleges();
            foreach (var C in colleges)
            {
                ComboboxItem item1 = new ComboboxItem();
                item1.Text = C.CollegeName;
                item1.Value = C.ID;
                cmbBxCollegeID.Items.Add(item1);
            }
            foreach (var A in colleges)
            {
                ComboboxItem item2 = new ComboboxItem();
                item2.Text = A.CollegeName;
                item2.Value = A.ID;
                cmbBoxStudentColID.Items.Add(item2);
            }

            dataGridVRegEmployees.DataSource = Manager.LoadRegularEmployees();
            dataGridVStudentEmployees.DataSource = Manager.LoadStudentEmployees();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBDepartment.SelectedItem == null || cmbBxCollegeID.SelectedItem == null)
            {
                MessageBox.Show("Please Add value");
                return;

            }

            bool Succesful = Manager.UpdateRegularEmployee(labLID.Text, txtBEmployeesID.Text, txtBFirstName.Text, txtBLastName.Text, txtBSSN.Text, DateTime.Parse(txtBDateOfBirth.Text), cmbBxGender.Text, cmbBxMaritalStatus.Text, ((ComboboxItem)cmbBxCollegeID.SelectedItem).Value, DateTime.Parse(txtBHireDate.Text), ((ComboboxItem)cmbBDepartment.SelectedItem).Value, chckBxYesGym.Checked);


            if (Succesful == true)
            {
                MessageBox.Show("New Employee successfully updated");
                dataGridVRegEmployees.DataSource = Manager.LoadRegularEmployees();


                clear();
            }

            else
            {
                MessageBox.Show("Failed to update new employee. Please try again");
            }
        }

        private void dataGridVRegEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            labLID.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[0].Value.ToString();
            txtBEmployeesID.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[1].Value.ToString();
            txtBFirstName.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[2].Value.ToString();
            txtBLastName.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[3].Value.ToString();
            txtBSSN.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[4].Value.ToString();
            txtBDateOfBirth.Text = ((DateTime)dataGridVRegEmployees.Rows[rowIndex].Cells[5].Value).ToShortDateString();
          
            foreach (ComboboxItem item in cmbBxCollegeID.Items)
            {
                if (item.Value == (int)dataGridVRegEmployees.Rows[rowIndex].Cells[6].Value)
                {
                    cmbBxCollegeID.SelectedItem = item;
                    break;
                }
            }


            txtBHireDate.Text = ((DateTime)dataGridVRegEmployees.Rows[rowIndex].Cells[7].Value).ToShortDateString();
            cmbBxGender.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[8].Value.ToString();
            cmbBxMaritalStatus.Text = dataGridVRegEmployees.Rows[rowIndex].Cells[9].Value.ToString();
            
            foreach (ComboboxItem item in cmbBDepartment.Items)
            {
                if (item.Value == (int)dataGridVRegEmployees.Rows[rowIndex].Cells[10].Value)
                {
                    cmbBDepartment.SelectedItem = item;
                    break;
                }
            }



            chckBxYesGym.Checked = (bool)dataGridVRegEmployees.Rows[rowIndex].Cells[11].Value;


        }

        private void dataGridVStudentEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            StudentIDLabel.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[0].Value.ToString();
            txtBxStudentEmployeeID.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[1].Value.ToString();
            textBStudentFirstName.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[2].Value.ToString();
            txtBStudentLastName.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[3].Value.ToString();
            txtBStudentSSN.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[4].Value.ToString();
            txtBStudentDateOfBirth.Text = ((DateTime)dataGridVStudentEmployees.Rows[rowIndex].Cells[5].Value).ToShortDateString();
            

            foreach (ComboboxItem item in cmbBoxStudentColID.Items)
            {
                if (item.Value == (int)dataGridVStudentEmployees.Rows[rowIndex].Cells[6].Value)
                {
                    cmbBoxStudentColID.SelectedItem = item;
                    break;
                }
            }

            txtBStartDate.Text = ((DateTime)dataGridVStudentEmployees.Rows[rowIndex].Cells[7].Value).ToShortDateString();
            cmbBStudentGender.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[8].Value.ToString();
            cmbBStudentMaritalStatus.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[9].Value.ToString();
            txtBCollegeYear.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[10].Value.ToString();
            txtBAverageHoursWeekly.Text = dataGridVStudentEmployees.Rows[rowIndex].Cells[11].Value.ToString();
           chckBoxStudentYES.Checked = (bool)dataGridVStudentEmployees.Rows[rowIndex].Cells[12].Value;
         

        }

        private void AddStudentbtn_Click(object sender, EventArgs e)
        {

            bool IsSuccesful = Manager.AddStudentEmployee(txtBxStudentEmployeeID.Text, textBStudentFirstName.Text, txtBStudentLastName.Text, txtBStudentSSN.Text, cmbBStudentGender.Text, DateTime.Parse(txtBStudentDateOfBirth.Text), cmbBStudentMaritalStatus.Text, ((ComboboxItem)cmbBoxStudentColID.SelectedItem).Value, DateTime.Parse(txtBStartDate.Text), int.Parse(txtBCollegeYear.Text), int.Parse(txtBAverageHoursWeekly.Text), chckBoxStudentYES.Checked);


            if (IsSuccesful == true)
            {
                MessageBox.Show("New Student Employee successfully added");
                dataGridVStudentEmployees.DataSource = Manager.LoadStudentEmployees();
                clear();
            }

            else
            {
                MessageBox.Show("Failed to add New Student Employee. Please try again");
            }
        }

        private void UpdateStudentbtn_Click(object sender, EventArgs e)
        {
            bool IsSuccesful = Manager.UpdateStudentEmployee(StudentIDLabel.Text, txtBxStudentEmployeeID.Text, textBStudentFirstName.Text, txtBStudentLastName.Text, txtBStudentSSN.Text, cmbBStudentGender.Text, DateTime.Parse(txtBStudentDateOfBirth.Text), cmbBStudentMaritalStatus.Text, ((ComboboxItem)cmbBoxStudentColID.SelectedItem).Value, DateTime.Parse(txtBStartDate.Text), int.Parse(txtBCollegeYear.Text), int.Parse(txtBAverageHoursWeekly.Text), chckBoxStudentYES.Checked);


            if (IsSuccesful == true)
            {
                MessageBox.Show("New Student Employee successfully Updated");
                dataGridVStudentEmployees.DataSource = Manager.LoadStudentEmployees();
                clear();
            }

            else
            {
                MessageBox.Show("Failed to Update new student employee. Please try again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool Success = Manager.DeleteRegularEmployee(int.Parse(labLID.Text));

            if (Success == true)

            {
                MessageBox.Show("Regular Employee has been succefully deleted");
              
                dataGridVRegEmployees.DataSource = Manager.LoadRegularEmployees();
                clear();
            }
            else

            {
                MessageBox.Show("Fail to delete, please try again");

            }
        }

        private void DeleteStudentbtn_Click(object sender, EventArgs e)
        {
            bool A_Success = Manager.DeleteStudentEmployee(int.Parse(StudentIDLabel.Text));
           
            if (A_Success == true)
            {
                MessageBox.Show("Student Employee has been succefully deleted");
                dataGridVStudentEmployees.DataSource = Manager.LoadStudentEmployees();
                clear();
            }
            else

            {
                MessageBox.Show("Fail to delete, please try again");

            }
        }

        private void btnCollege_Click(object sender, EventArgs e)
        {
            frmCollege college = new frmCollege();
            college.ShowDialog();
        }
    }

}