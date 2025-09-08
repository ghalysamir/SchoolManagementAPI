namespace SchoolManagementAPI.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        // FK to Teacher
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; } = null!;

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
