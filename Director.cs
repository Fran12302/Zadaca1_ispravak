namespace zadaca_1
{
    public class Director:Person
    {
        List<SchoolClass> schoolClasses; 
        List<Person> schoolPeople;
       
        public Director(string name, string surname, int id):base(name, surname, id) {
          
            schoolPeople= new List<Person>();
            schoolClasses= new List<SchoolClass>();
        
        }

        public void AddPerson(Person person)
        {
            schoolPeople.Add(person);
        }

        public void RemovePerson(Person person) { 
          schoolPeople.Remove(person);
        }

        public void AddStudentoClass(SchoolClass schoolClass, Student student)
        {
            schoolClass.AddStudent(student);
        }

        public void SchoolclassesMarks()
        {
            foreach(var schoolClass in schoolClasses)
            {
                Console.WriteLine(schoolClass.Name);
                schoolClass.ShowSchoolClassMarks();
            }

            
        }
        

    }
}