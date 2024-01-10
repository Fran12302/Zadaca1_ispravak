namespace zadaca_1
{
    public class Student:Person
    {
        private string nameOfSchollClass;
        private List<int> marks { get; set; }

        public Student(string name, string surname, int id,string nameOfSchollClass):base(name,surname,id)
        {
            this.nameOfSchollClass = nameOfSchollClass;
            this.marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            marks.Add(mark);
        }

        public void ShowMarks()
        {
            Console.WriteLine($"{this.GetName()}");
            foreach (var mark in marks)

            {
                
                Console.WriteLine(mark);
            }
        }

    }
}