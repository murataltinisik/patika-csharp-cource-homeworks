# Baby Class Project

## Class Properties
1. Name: Define baby name.
2. Surname: Define baby surname.
3. DateOfBirth: Define baby birthdate.

All properties have defined getter and setter but getters are public and setters are private because Name and Surname properties are given to Constructor so defined setters are private.

```
class Baby 
{
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public DateTime DateOfBirth { get; private set; }

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
        if (Name != null && Surname != null) {
            Console.WriteLine($"Ad: {Name} Soyad: {Surname} - Doğum Tarihi: {DateOfBirth}");
        }
        else
        {
            Console.WriteLine($"Doğum Tarihi:{DateOfBirth}");
        }
    }
}
```

## Usage Class
```
// Create Baby Class
Baby baby = new Baby(); // Empty 
baby.PrintBaby();


// Create Baby Class -> With Properties
Baby baby2 = new Baby("Murat", "Altınışık");
baby2.PrintBaby();
```