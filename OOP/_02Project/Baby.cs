namespace OOP
{
    class Baby
    {
        public string Name
        {
            get; private set;
        }
        public string Surname
        {
            get; private set;
        }
        public DateTime DateOfBirth
        {
            get; private set;
        }

        public Baby()
        {
            DateOfBirth = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        public void PrintBaby()
        {
            if (Name != null && Surname != null)
            {
                Console.WriteLine($"Ad: {Name} Soyad: {Surname} - Doğum Tarihi: {DateOfBirth}");
            }
            else
            {
                Console.WriteLine($"Doğum Tarihi: {DateOfBirth}");
            }
        }
    }
}