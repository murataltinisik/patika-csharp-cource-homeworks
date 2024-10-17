using OOP;

namespace OOP
{
    abstract class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Department { get; private set; }

        public Employee(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public abstract void GetTask();
    }

    class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string name, string surname, string department) : base(name, surname, department) { }

        public override void GetTask()
        {
            Console.WriteLine("{0} {1} adlı personel, yazılım geliştiricisi olarak çalışıyor.", Name, Surname);
        }
    }

    class ProjectManager : Employee
    {
        public ProjectManager(string name, string surname, string department) : base(name, surname, department) { }

        public override void GetTask()
        {
            Console.WriteLine("{0} {1} adlı personel, proje yöneticisi olarak çalışıyor.", Name, Surname);
        }
    }

    class SalesRepresentative : Employee
    {
        public SalesRepresentative(string name, string surname, string department) : base(name, surname, department) { }

        public override void GetTask()
        {
            Console.WriteLine("{0} {1} adlı personel, satış temsilcisi olarak çalışıyor.", Name, Surname);
        }
    }

}