namespace SchoolManagementAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SchoolClassId { get; set; }

        public string AssessmentName { get; set; } = string.Empty;

        public decimal Score { get; set; }

        public string Remarks { get; set; } = string.Empty;

        public Student Student { get; set; } = null!;

        public SchoolClass SchoolClass { get; set; } = null!;
    }
}
