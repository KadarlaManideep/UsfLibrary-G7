namespace UsfLibrary_G7.Models
{

    public sealed class Student : Person
    {
        public string Major { get; }
        public int GraduationYear { get; }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }
    }

}