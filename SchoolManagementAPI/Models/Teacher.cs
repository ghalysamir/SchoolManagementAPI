namespace SchoolManagementAPI.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
         
        public string LastName { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        // علاقات
        public ICollection<SchoolClass> Classes { get; set; } = new List<SchoolClass>();
    }
}
