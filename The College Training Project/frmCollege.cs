using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using The_College_Training_Project.Models;
using The_Connection.MiddleTierData;

namespace The_College_Training_Project
{
    public partial class frmCollege : Form
    {
        public frmCollege()
        {
            InitializeComponent();
        }

        MiddleTier Manager = new MiddleTier();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool success = Manager.AddCollege(txtBoxCollegeName.Text, txtBoxCollegAddress.Text);
            if (success == true)
            {
                MessageBox.Show("New College successfully added");
                dataGridVCollege.DataSource = Manager.LoadColleges();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new college. Please try again");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            CollegeIDlabel.Text = "";
            txtBoxCollegeName.Text = "";
            txtBoxCollegAddress.Text = "";
        }

        private void dataGridVCollege_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            CollegeIDlabel.Text = dataGridVCollege.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxCollegeName.Text = dataGridVCollege.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxCollegAddress.Text = dataGridVCollege.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            bool IsSuccess = Manager.UpdateCollege(CollegeIDlabel.Text, txtBoxCollegeName.Text, txtBoxCollegAddress.Text);
            if (IsSuccess == true)
            {
                MessageBox.Show("College successfully Updated");
                dataGridVCollege.DataSource = Manager.LoadColleges();
                Clear();
            }
            else
            {
                MessageBox.Show("Failled to update college. Please try again.");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsASuccess = Manager.DeleteCollege(int.Parse(CollegeIDlabel.Text));
            if (IsASuccess == true)
            {
                MessageBox.Show("College successfully Delete");
                dataGridVCollege.DataSource = Manager.LoadColleges();
                Clear();
            }
            else
            {
                MessageBox.Show("Failled to delete college. Please try again.");
            }
        }

        private void frmCollege_Load(object sender, EventArgs e)
        {
            dataGridVCollege.DataSource = Manager.LoadColleges();
        }
    }
}

