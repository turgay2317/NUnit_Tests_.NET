namespace NUnit_Tests_.NET
{
    [TestFixture]
    public class GradeTests
    {
        private List<Student> _students;
        private List<Class> _classes;
        private List<Grade> _grades = new List<Grade>();

        // Genel test çalýþtýrýldýðýnda öðrenci ve sýnýflarý getirelim.
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _students = Database.Students.ToList();
            _classes = Database.Classes.ToList();
        }

        // Genel test bittiðinde öðrenci ve sýnýflarý temizleyelim.
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _students.Clear();
            _classes.Clear();
        }

        // Her bir test metodundan önce öðrencilere not atayalým.
        [SetUp]
        public void Setup()
        {
            GenerateRandomGradesForStudents();
        }

        // Her bir test metodundan sonra notlarý temizleyelim.
        [TearDown]
        public void TearDown()
        {
            _grades.Clear();
        }

        [Test]
        public void Each_Student_Has_Exactly_One_Grade_Per_Class()
        {
            var expected = _students.Count * _classes.Count;
            Assert.That(_grades, Has.Count.EqualTo(expected));

            var uniquePairs = _grades
                .Select(g => (g.Student.FullName, g.Class.Name))
                .Distinct()
                .Count();

            Assert.That(uniquePairs, Is.EqualTo(_grades.Count));
        }

        [Test]
        public void All_The_Grades_Must_Be_Between_0_And_100()
        {
            Assert.That(_grades, Has.All.Matches<Grade>(g => g.Result >= 0 && g.Result <= 100));
        }

        [TestCase(80, 60, 70)]
        [TestCase(100, 0, 50)]
        [TestCase(90, 90, 90)]
        public void Average_Grade_Is_Calculated_Correctly(int grade1, int grade2, double expectedAverage)
        {
            var student = new Student(1, "Ali");
            var classes = new List<Class>
            {
                new Class("Math", 5),
                new Class("Physics", 4)
            };

            var grades = new List<Grade>
            {
                new Grade(student, classes[0], grade1),
                new Grade(student, classes[1], grade2)
            };

            var average = grades.Average(g => g.Result);

            Assert.That(average, Is.EqualTo(expectedAverage));
        }

        private void GenerateRandomGradesForStudents()
        {
            Random rnd = new Random();

            foreach (var student in _students)
            {
                foreach (var cls in _classes)
                {
                    int grade = rnd.Next(0, 101);
                    _grades.Add(new Grade(student, cls, grade));
                }
            }
        }
    }
}