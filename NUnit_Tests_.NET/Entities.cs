namespace NUnit_Tests_.NET
{
    public record Student(int No, string FullName);

    public record Class(string Name, float PassGrade);

    public record Grade(Student Student, Class Class, float Result)
    {
        public bool Passed => Result >= Class.PassGrade;
    }
}
