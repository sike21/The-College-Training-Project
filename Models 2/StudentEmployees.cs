using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_College_Training_Project.Models
{
   public  class StudentEmployees
    {
        public int ID { get; set; }
        public int StudentEmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CollegeID { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int CollegeYear { get; set; }
        public int AverageHoursWeekly { get; set;}
        public bool StudentLoan { get; set; }
    }
}
