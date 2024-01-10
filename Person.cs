namespace zadaca_1
{
    public abstract class Person
    {
        private string name;
        private int id;
        private string surname;

        
        public Person(string name, string surname, int id) {
            this.name = name;
            this.surname = surname;
            this.id = id;
        }

        public string GetName()
        {
            return name;

        }

        public string GetSurname() { return surname; }

         public int GetId() { return id; }

        public void SetName(string name) { this.name = name; }
        public void SetSurname(string surname) { this.surname = surname; }

        public void SetId(int id) { this.id = id;}

        public override string ToString()
        {
            return $"{name} {surname} {id}";
        }

    }
}