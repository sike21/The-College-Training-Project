# The-College-Training-Project
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using The_College_Training_Project.Connection;
using The_College_Training_Project.Models;

namespace The_Connection.MiddleTierData
{
    public class MiddleTier
    {
        public static List<StudentEmployees> StudentEmployees = new List<StudentEmployees>();

        public static List<College> Colleges = new List<College>();
        public bool AddCollege(string collegeName, string collegeAddress)
        {
            if (collegeName == "" || collegeAddress == "")
            {
                return false;

            }
            else
            {
                try
                {
                   ProjectConnection project = new ProjectConnection();
                    project.AddCollege(collegeName, collegeAddress);
                    return true;
                }
                catch (Exception e)
                {

                    return false;
                    
                }
               
            }

        }
        public bool UpdateCollege(string ID, string collegeName, string collegeAddress)
        {
            if (ID == "" || collegeName == "" || collegeAddress == "")
            {
                return false;

            }
            else
            {
                int AutoID;
                if (!int.TryParse(ID, out AutoID))
                {
                    return false;
                }
                else
                {

                    try
                    {
                        ProjectConnection project = new ProjectConnection();
                        project.UpdateCollege(AutoID, collegeName, collegeAddress);
                        return true;
                    }
                    catch (Exception e)
                    {

                        return false;
                    }

                }

            }
        }

        public bool DeleteCollege(int ID)
        {
            ProjectConnection connection = new ProjectConnection();
            List<RegularEmployees> regularEmployees = LoadRegularEmployees();
            
            foreach (var Row in regularEmployees)
            {

                if (Row.CollegeID == ID)
                {
                    return false;
                }

            }
            List<StudentEmployees> studentEmployees = LoadStudentEmployees();

            foreach (var Row in studentEmployees)
            {

                if (Row.CollegeID == ID)
                {
                    return false;
                }

            }
            try
            {
                connection.DeleteCollege(ID);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
            
        }

        
        public static List<RegularEmployees> RegularEmployees = new List<RegularEmployees>();
        public bool AddRegularEmployee(string EmployeeID, string FirstName, string LastName, string SocialSecurityNumber, DateTime DateOfBirth, string Gender, string MaritalStatus, int CollegeID, DateTime HireDate, int Department, bool GymMember)
        {

            if (EmployeeID == "" || FirstName == "" || LastName == "" || SocialSecurityNumber == "" || Gender == "" || MaritalStatus == "")
            {
                return false;
            }
            else
            {
                int employeeID;
                if (!int.TryParse(EmployeeID, out employeeID))
                {
                    return false;
                }

                else
                {
                    try
                    {
                        ProjectConnection project = new ProjectConnection();
                        project.AddRegularEmployee(employeeID, FirstName, LastName, SocialSecurityNumber, DateOfBirth, Gender, MaritalStatus, CollegeID, DateOfBirth, Department, GymMember);
                        return true;
                    }
                    catch (Exception e)
                    {

                        return false;
                    }

                }

            }
        }
        public bool UpdateRegularEmployee(string ID, string EmployeeID, string FirstName, string LastName, string SocialSecurityNumber, DateTime DateOfBirth, string Gender, string MaritalStatus, int CollegeID, DateTime HireDate, int Department, bool GymMember)
        {

            if (ID == "" || EmployeeID == "" || FirstName == "" || LastName == "" || SocialSecurityNumber == "" || Gender == "" || MaritalStatus == "")
            {
                return false;
            }
            else
            {
                int AutoID;
                if (!int.TryParse(ID, out AutoID))
                {
                    return false;
                }
                int employeeID;
                if (!int.TryParse(EmployeeID, out employeeID))
                {
                    return false;
                }

                else
                {
                    try
                    {
                        ProjectConnection project = new ProjectConnection();
                        project.UpdateRegularEmployee(AutoID, employeeID, FirstName, LastName, SocialSecurityNumber, DateOfBirth, Gender, MaritalStatus, CollegeID, HireDate, Department, GymMember);
                        return true;
                    }
                    catch (Exception e)
                    {

                        return false;
                    }
                    
                }
            }

        }
        public bool DeleteRegularEmployee(int ID)
        {
            ProjectConnection connection = new ProjectConnection();
            List<RegularEmployees> regularEmployees = LoadRegularEmployees();

            bool check = false;
           

            foreach (var Row in regularEmployees)
            {
             
                if (Row.ID == ID)
                {
                    check = true;
                    break;
                }
              
            }
            if (check ) 
            {
                
                connection.DeleteRegularEmployee(ID);
                
            }
            return check;
        }

        public static List<StudentEmployees> StudentEmployee = new List<StudentEmployees>();
        public bool AddStudentEmployee(string StudentEmployeeID, string FirstName, string LastName, string SocialSecurityNumber, string Gender, DateTime DateOfBirth, string MaritalStatus, int CollegeID, DateTime StartDate, int CollegeYear,int AverageHoursWeekly ,bool StudentLoan)
        {

            if (StudentEmployeeID == "" || FirstName == "" || LastName == "" || SocialSecurityNumber == "" || Gender == "" || MaritalStatus == "")
            {
                return false;
            }
            else
            {
                int studentemployeeID;
                if (!int.TryParse(StudentEmployeeID, out studentemployeeID))
                {
                    return false;
                }

                else
                {
                    try
                    {
                        ProjectConnection project = new ProjectConnection();
                        project.AddStudentEmployee(studentemployeeID, FirstName, LastName, SocialSecurityNumber, Gender, DateOfBirth, MaritalStatus, CollegeID, StartDate, CollegeYear, AverageHoursWeekly, StudentLoan);
                        return true;
                    }
                    catch (Exception e)
                    {

                        return false;
                    }
                   
                }
            }

        }
        public bool UpdateStudentEmployee(string ID, string StudentEmployeeID, string FirstName, string LastName, string SocialSecurityNumber, string Gender, DateTime DateOfBirth,  string MaritalStatus, int CollegeID, DateTime StartDate, int CollegeYear, int AverageHoursWeekly, bool StudentLoan)
        {

            if (ID == "" || StudentEmployeeID == "" || FirstName == "" || LastName == "" || SocialSecurityNumber == "" || Gender == "" || MaritalStatus == "")
            {
                return false;
            }
            else
            {
                int AutoID;
                if (!int.TryParse(ID, out AutoID))
                {
                    return false;
                }
                int studentemployeeID;
                if (!int.TryParse(StudentEmployeeID, out studentemployeeID))
                {
                    return false;
                }

                else
                {
                    try
                    {
                        ProjectConnection project = new ProjectConnection();
                        project.UpdateStudentEmployee(AutoID, studentemployeeID, FirstName, LastName, SocialSecurityNumber, Gender, DateOfBirth, MaritalStatus, CollegeID, StartDate, CollegeYear, AverageHoursWeekly, StudentLoan);
                        return true;
                    }
                    catch (Exception e)
                    {

                        return false;
                    }
                   
                }
            }

        }
        public bool DeleteStudentEmployee(int ID)
        {
            ProjectConnection connection = new ProjectConnection();
            List<StudentEmployees> studentEmployees = LoadStudentEmployees();

            bool check = false;


            foreach (var Row in studentEmployees)
            {

                if (Row.ID == ID)
                {
                    check = true;
                    break;
                }

            }
            if (check)
            {
                connection.DeleteStudentEmployee(ID);

            }
            return check;
        }

        public List<RegularEmployees> LoadRegularEmployees()
        {
            ProjectConnection connection = new ProjectConnection();
            List<RegularEmployees> regularEmployees = new List<RegularEmployees>();
            connection.LoadRegularEmployees();
            if (connection.SqlTable.Tables.Count > 0)
            {
                foreach (DataRow Row in connection.SqlTable.Tables[0].Rows)
                {
                    RegularEmployees A = new RegularEmployees();
                    A.ID = (int)Row["ID"];
                    A.EmployeeID = (int)Row["EmployeeID"];
                    A.FirstName = Row["FirstName"].ToString();
                    A.LastName = Row["LastName"].ToString();
                    A.SocialSecurityNumber = Row["SocialSecurityNumber"].ToString();
                    A.DateOfBirth = (DateTime)Row["DateOfBirth"];
                    A.CollegeID = (int)Row["CollegeID"];
                    A.HireDate = (DateTime)Row["HireDate"];
                    A.Gender = Row["Gender"].ToString();
                    A.MaritalStatus = Row["MaritalStatus"].ToString();      
                    A.Department = (int)Row["Department"];
                    A.GymMember = (bool)Row["GymMember"];
                    regularEmployees.Add(A);

                }
                
            }
            RegularEmployees = regularEmployees;
            return regularEmployees;
        }

        public List<StudentEmployees> LoadStudentEmployees()
        {
            ProjectConnection connection = new ProjectConnection();
            List<StudentEmployees> studentEmployees = new List<StudentEmployees>();
            connection.LoadStudentEmployees();
            if (connection.SqlTable.Tables.Count > 0)
            {
                foreach (DataRow Row in connection.SqlTable.Tables[0].Rows)
                {
                    StudentEmployees B = new StudentEmployees();
                    B.ID = (int)Row["ID"];
                    B.StudentEmployeeID = (int)Row["StudentEmployeesID"];
                    B.FirstName = Row["FirstName"].ToString();
                    B.LastName = Row["LastName"].ToString();
                    B.SocialSecurityNumber = Row["SocialSecurityNumber"].ToString();
                    B.DateOfBirth = (DateTime)Row["DateOfBirth"];
                    B.CollegeID = (int)Row["CollegeID"];
                    B.StartDate = (DateTime)Row["StartDate"];
                    B.Gender = Row["Gender"].ToString();
                    B.MaritalStatus = Row["MaritalStatus"].ToString();
                    B.CollegeYear = (int)Row["CollegeYear"];
                    B.AverageHoursWeekly = (int)Row["AverageHoursWeekly"];
                    B.StudentLoan = (bool)Row["StudentLoan"];
                    studentEmployees.Add(B);

                }

            }
            StudentEmployees = studentEmployees;
            return studentEmployees;
        }




        public List<College> LoadColleges()
        {
            ProjectConnection connection = new ProjectConnection();
            List<College> colleges = new List<College>();
            connection.LoadCollege();
            if (connection.SqlTable.Tables.Count > 0)
            {
                foreach (DataRow Row in connection.SqlTable.Tables[0].Rows)
                {
                    College C = new College();
                    C.ID = (int)Row["ID"];
                    C.CollegeName = Row["CollegeName"].ToString();
                    C.CollegeAddress = Row["CollegeAddress"].ToString();
                    colleges.Add(C);
                }
            }
            Colleges = colleges;
            return colleges;
        }
   
    }
    
}
