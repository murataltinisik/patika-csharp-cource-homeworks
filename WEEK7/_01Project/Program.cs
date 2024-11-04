// Variables
Random random = new Random();
List<int> numbers = new List<int>();


// Add random number to list
for (int i = 0; i < 10; i++) numbers.Add(random.Next(-100,100));

// ------------- 1. Question -------------
// Even Numbers
foreach (var number in numbers.Where(n => n % 2 == 0)) Console.WriteLine(number);

Console.WriteLine("----------------------");

// Odd Numbers
foreach (var number in numbers.Where(n => n % 2 == 1)) Console.WriteLine(number);

Console.WriteLine("----------------------");

// ------------- 2. Question -------------

// Even Numbers
foreach (var number in numbers.Where(n => n < 0)) Console.WriteLine(number);

Console.WriteLine("----------------------");

// Odd Numbers
foreach (var number in numbers.Where(n => n > 0)) Console.WriteLine(number);

Console.WriteLine("----------------------");

// ------------- 3. Question -------------
List<int> betweenNumbers = (from number in numbers where number > 15 && number < 22 select number).ToList();

foreach (var number in betweenNumbers) Console.WriteLine(number);

Console.WriteLine("----------------------");

// ------------- 4. Question -------------
foreach (var number in numbers.Select(n => n * n)) Console.WriteLine(number);