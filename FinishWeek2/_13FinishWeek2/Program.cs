// reverse value
void ReverseValue(ref string str1, ref string str2)
{
    // Reverse
    string temp = str1;
    str1 = str2;
    str2 = temp;
}

// Variables
string str1 = string.Empty;
string str2 = string.Empty;

// Get Values
Console.Write("1. İsmi Giriniz: ");
str1 = Console.ReadLine();

Console.Write("2. İsmi Giriniz: ");
str2 = Console.ReadLine();

// Call Method
ReverseValue(ref str1, ref str2);
Console.WriteLine($"İsim 1: {str1}, İsim 2: {str2}");