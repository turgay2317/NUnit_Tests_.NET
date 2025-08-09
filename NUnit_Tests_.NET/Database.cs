namespace NUnit_Tests_.NET
{
    public static class Database
    {
        public static List<Student> Students = new List<Student>
        {
            new(1, "Turgay Ceylan"),
            new(2, "Yalçın Ceylan"),
            new(3, "Berke Kesgin"),
            new(4, "Bertan Sezgin")
        };

        public static List<Class> Classes = new List<Class>
        {
            new("Calculus", 50),
            new("Computer Organization", 40),
            new("Programming", 70)
        };

        public static List<Grade> Grades = new List<Grade>();
    }
}
