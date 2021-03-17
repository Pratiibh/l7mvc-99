using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//tinfo200:[2021-03-14-pratiibh-dykstra1] - Created a class to hold all information that would be required for a potential students enrollment.  For example, student ID, last name, first name, enrollment date, etc.

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
