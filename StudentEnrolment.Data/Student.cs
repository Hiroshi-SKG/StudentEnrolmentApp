namespace StudentEnrolment.Data
{
    public class Student:Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string Picture { get; set; }
    }
}