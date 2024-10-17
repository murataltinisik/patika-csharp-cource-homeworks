namespace OOP
{
    class BasePerson
    {
        // Class Properties
        private string name;
        private string surname;

        // Getters and Setters Of Properties
        protected string Name { get; set; }
        protected string Surname { get; set; }

        // Print Properties
        public virtual void Print()
        {
            Console.WriteLine("Ad: {0}, Soyad: {1}", Name, Surname);
        }
    }

    class Teacher : BasePerson
    {
        private double salary;

        public double Salary { get; set; }

        public Teacher(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine("Öğretment -> Ad: {0}, Soyad: {1}, Maaş: {2}", Name, Surname, Salary);
        }
    }

    class Student : BasePerson
    {
        private int number;

        public int Number { get; set; }

        public Student(string name, string surname, int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public override void Print()
        {
            Console.WriteLine("Öğrenci -> Ad: {0}, Soyad: {1}, Numara: {2}", Name, Surname, Number);
        }
    }
}