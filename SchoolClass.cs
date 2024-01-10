namespace zadaca_1
{
    public class SchoolClass
    {
        public string Name {  get; private set; }

        private List<Student> students;

        public SchoolClass(string name)
        {
            Name = name;
            this.students =new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void ShowSchoolClassMarks()
        {
            foreach (var student in this.students)
            {
               
                student.ShowMarks();
            }
        }
    }
}