using System.ComponentModel;
using System.Globalization;

namespace zadaca_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student Student1 = new Student("Marko", "Grizelj", 1234, "3.a");
            Student Student2 = new Student("Bruno", "Petković", 4567, "3.a");
            List<Student> studenti = new List<Student>();
            studenti.Add(Student1);
            studenti.Add(Student2);


            Teacher Ucitelj = new Teacher(8932, "Luka", "Modrić");

            SchoolClass prvi = new SchoolClass("3.a");

           prvi.AddStudent(Student1);
           prvi.AddStudent(Student2);

            Director Ravnatelj = new Director("Šegrt", "Hlapić", 9781);

            Ucitelj.TeacherAddMark(Student1, 2);
            Ucitelj.TeacherAddMark(Student1, 3);
            Ucitelj.TeacherAddMark(Student1, 4);

            Ucitelj.TeacherAddMark(Student2, 5);
            Ucitelj.TeacherAddMark(Student2, 1);

            Student1.ShowMarks();

            prvi.ShowSchoolClassMarks();

            Console.WriteLine($"{Student1.GetName()} {Student1.GetSurname()}- NJEGOV ID:{Student1.GetId()}");

        }
    }
}