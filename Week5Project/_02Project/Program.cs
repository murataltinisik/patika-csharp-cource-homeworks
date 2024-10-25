// Define List
List<string> guests = new List<string>();

// Add item to List
guests.Add("Bülent Ersoy");
guests.Add("Ajda Pekkan");
guests.Add("Ebru Gündeş");
guests.Add("Hadise");
guests.Add("Hande Yener");
guests.Add("Tarkan");
guests.Add("Funda Arar");
guests.Add("Demet Akalın");

// Write Console
Console.WriteLine("------- DAVETLİLER -------");
Console.WriteLine("--------------------------");
for (int i = 0; i < guests.Count; i++) 
    Console.WriteLine("{0} - {1}", i+1, guests[i]);
