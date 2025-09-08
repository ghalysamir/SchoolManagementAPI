namespace SchoolManagementAPI.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SchoolClassId { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public Student Student { get; set; } = null!;

        public SchoolClass SchoolClass { get; set; } = null!;
    }
}
