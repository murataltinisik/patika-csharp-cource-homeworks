// Variable
int numberOfTrue = 0;

// Question 1
Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("a) Lama  b) Deve");
Console.Write("Cevabınız: ");
string answer1 = Console.ReadLine().ToLower();

// Check Question 1
Console.WriteLine();
if (answer1 == "a") {
    numberOfTrue += 1;
    Console.WriteLine("Tebrikler!! Cevabınız Doğru.");
} else {
    Console.WriteLine("Opps!! Cevabınız Yanlış.");
}
Console.WriteLine();

// Question 2
Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("a) Venüs  b) Mars");
Console.Write("Cevabınız: ");
string answer2 = Console.ReadLine().ToLower();

// Check Question 2
Console.WriteLine();
if (answer2 == "a") {
    numberOfTrue += 1;
    Console.WriteLine("Tebrikler!! Cevabınız Doğru.");
} else {
    Console.WriteLine("Opps!! Cevabınız Yanlış.");
}
Console.WriteLine();

// Control numberOfTrue 
if(numberOfTrue == 2) {
    Console.WriteLine("TEBRIKLER!! 1 Milyon TL'lik büyük ödülü KAZANDINIZ...");
    return;
}

// Question 3
Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
Console.WriteLine("a) 7  b) 12");
Console.Write("Cevabınız: ");
string answer3 = Console.ReadLine().ToLower();

// Check Question 3
Console.WriteLine();
if (answer3 == "b") {
    numberOfTrue += 1;
    Console.WriteLine("Tebrikler!! Cevabınız Doğru.");
} else {
    Console.WriteLine("Opps!! Cevabınız Yanlış.");
}
Console.WriteLine();

// Control numberOfTrue 
if (numberOfTrue == 2) {
    Console.WriteLine("TEBRIKLER!! 1 Milyon TL'lik büyük ödülü KAZANDINIZ...");
} else {
    Console.WriteLine("Yarışmayı kazanamadınız!!! Tekrar deneyin." +
        "");
}