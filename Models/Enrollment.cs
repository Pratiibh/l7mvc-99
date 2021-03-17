namespace ContosoUniversity.Models
{

    //tinfo200:[2021-03-14-pratiibh-dykstra1] - Created a class to hold all school-related information that would be required for a potential students enrollment.  For example, enrollment ID, course ID, student ID, grades (A, B, C, D, or F), etc.

    public enum Grade
    {
        A, B, C, D, F,
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        
        public Student Student { get; set; }
    }
}