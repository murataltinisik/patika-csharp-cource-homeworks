// Get Values
Console.Write("1- Ad Soyad Bilgisi Giriniz: ");
string name1 = Console.ReadLine();

Console.Write("2- Ad Soyad Bilgisi Giriniz: ");
string name2 = Console.ReadLine();

// Finish
string temp = name1; 
name1 = name2; 
name2 = temp;

Console.WriteLine($"{name1} {name2}");