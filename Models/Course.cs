using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


//tinfo200:[2021-03-14-pratiibh-dykstra1] - Created a class to hold all school-related course information that would be required for a potential students enrollment.  For example, Course ID, Title of Course, Credits receivable, etc.


namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
