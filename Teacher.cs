namespace zadaca_1
{
    public class Teacher : Person
    {
        List<string> subjects;

        public Teacher(int id, string name, string surname):base(name, surname, id)
        {
            subjects = new List<string>();
        }

        public void TeacherAddMark(Student student, int mark)
        {
            student.AddMark(mark);
        }
        
        public void ShowStudentMarks(Student student)
        {
            student.ShowMarks();
        }

        public void ShowClassMarks(List<Student> students)
        {
            foreach (Student student in students)
            {
              
                ShowStudentMarks(student);
            }
        }

     

    }
}