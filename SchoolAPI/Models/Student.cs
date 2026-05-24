namespace SchoolAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? RollNumber { get; set; }

        public int Semester { get; set; }

        public double Marks { get; set; }
    }
}