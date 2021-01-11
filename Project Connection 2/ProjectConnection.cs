using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace The_College_Training_Project.Connection
{
    public class ProjectConnection
    {
        SqlConnection SqlConn = new SqlConnection();
        public DataSet SqlTable = new DataSet();
        public ProjectConnection()
        {
            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;
        }
        private void retrieveData(string command)
        {
            try
            {
                SqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, SqlConn);
                da.Fill(SqlTable);
            }
            catch (Exception)
            {

            }
            finally
            {
                SqlConn.Close();
            }
        }
        
        //The College Session
        public void LoadCollege()
        {
            retrieveData("dbo.usp_sel_ShowColleges");
        }

        public void ProcWithParameters(SqlCommand command)
        {

            try
            {
                SqlConn.Open();
                command.Connection = SqlConn;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
                throw;
            }
            finally
            {
                SqlConn.Close();
            }
        }
        public void AddCollege(string collegeName, string collegeAddress)
        {

            SqlCommand command = new SqlCommand("dbo.InsertCollege");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@CollegeName", SqlDbType.VarChar).Value = collegeName;
            command.Parameters.Add("@CollegeAddress", SqlDbType.VarChar).Value = collegeAddress;

            ProcWithParameters(command);
        }
        public void UpdateCollege(int ID, string collegeName, string collegeAddress)
        {
            SqlCommand command = new SqlCommand("dbo.UpdateColleges");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@CollegeName", SqlDbType.VarChar).Value = collegeName;
            command.Parameters.Add("@CollegeAddress", SqlDbType.VarChar).Value = collegeAddress;

            ProcWithParameters(command);
        }
        public void DeleteCollege(int ID)
        {
            SqlCommand command = new SqlCommand("dbo.DeleteRegularEmployessCollege");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            

            ProcWithParameters(command);

        }
        


        
        


        //The Regular Employees Session
        public void LoadRegularEmployees()
        {
            retrieveData("dbo.SelectRegularEmployees");
        }
        public void AddRegularEmployee(int EmployeeID, string FirstName, string LastName, string SocialSecurityNumber, DateTime DateOfBirth, string Gender, string MaritalStatus, int CollegeID, DateTime HireDate, int Department, bool GymMember)
        {
            SqlCommand command = new SqlCommand("dbo.InsertRegularEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeID;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@SocialSecurityNumber", SqlDbType.VarChar).Value = SocialSecurityNumber;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@MaritalStatus", SqlDbType.VarChar).Value = MaritalStatus;
            command.Parameters.Add("@CollegeID", SqlDbType.Int).Value = CollegeID;
            command.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = HireDate;
            command.Parameters.Add("@Department", SqlDbType.Int).Value = Department;
            command.Parameters.Add("@GymMember", SqlDbType.Bit).Value = GymMember;

            ProcWithParameters(command);
        }
        public void UpdateRegularEmployee(int ID, int EmployeeID, string FirstName, string LastName, string SocialSecurityNumber, DateTime DateOfBirth, string Gender, string MaritalStatus, int CollegeID, DateTime HireDate, int Department, bool GymMember)
        {
            SqlCommand command = new SqlCommand("dbo.UpdateRegularEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@EmployeesID", SqlDbType.Int).Value = EmployeeID;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@SocialSecurityNumber", SqlDbType.VarChar).Value = SocialSecurityNumber;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@MaritalStatus", SqlDbType.VarChar).Value = MaritalStatus;
            command.Parameters.Add("@CollegeID", SqlDbType.Int).Value = CollegeID;
            command.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = HireDate;
            command.Parameters.Add("@Department", SqlDbType.Int).Value = Department;
            command.Parameters.Add("@GymMember", SqlDbType.Bit).Value = GymMember;

            ProcWithParameters(command);
        }
        public void DeleteRegularEmployee(int ID)
        {
            SqlCommand command = new SqlCommand("dbo.DeleteRegularEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
   
            ProcWithParameters(command);
        }
       

        //The Student Employees Session
        public void LoadStudentEmployees()
        {
            retrieveData("dbo.SelectStudentEmployees");
        }
        public void AddStudentEmployee(int StudentEmployeeID, string FirstName, string LastName, string SocialSecurityNumber, string Gender, DateTime DateOfBirth, string MaritalStatus, int CollegeID, DateTime StartDate, int CollegeYear,int AverageHoursWeekly, bool StudentLoan)
        {
            SqlCommand command = new SqlCommand("dbo.InsertStudentEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@StudentEmployeeID", SqlDbType.Int).Value = StudentEmployeeID;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@SocialSecurityNumber", SqlDbType.VarChar).Value = SocialSecurityNumber;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            command.Parameters.Add("@MaritalStatus", SqlDbType.VarChar).Value = MaritalStatus;
            command.Parameters.Add("@CollegeID", SqlDbType.Int).Value = CollegeID;
            command.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
            command.Parameters.Add("@CollegeYear", SqlDbType.Int).Value = CollegeYear;
            command.Parameters.Add("@AverageHoursWeekly", SqlDbType.Int).Value = AverageHoursWeekly;
            command.Parameters.Add("@StudentLoan", SqlDbType.Bit).Value = StudentLoan;

            ProcWithParameters(command);
        }
        public void UpdateStudentEmployee(int ID,int StudentEmployeeID, string FirstName, string LastName, string SocialSecurityNumber, string Gender, DateTime DateOfBirth, string MaritalStatus, int CollegeID, DateTime StartDate, int CollegeYear, int AverageHoursWeekly, bool StudentLoan)
        {
            SqlCommand command = new SqlCommand("dbo.UpdateStudentEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@StudentEmployeeID", SqlDbType.Int).Value = StudentEmployeeID;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@SocialSecurityNumber", SqlDbType.VarChar).Value = SocialSecurityNumber;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateOfBirth;
            command.Parameters.Add("@MaritalStatus", SqlDbType.VarChar).Value = MaritalStatus;
            command.Parameters.Add("@CollegeID", SqlDbType.Int).Value = CollegeID;
            command.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
            command.Parameters.Add("@CollegeYear", SqlDbType.Int).Value = CollegeYear;
            command.Parameters.Add("@AverageHoursWeekly", SqlDbType.Int).Value = AverageHoursWeekly;
            command.Parameters.Add("@StudentLoan", SqlDbType.Bit).Value = StudentLoan;

            ProcWithParameters(command);
        }
        public void DeleteStudentEmployee(int ID)
        {
            SqlCommand command = new SqlCommand("dbo.DeleteStudentEmployees");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            ProcWithParameters(command);
        }
        

    }

}
