using System;
using OOP;

namespace _02Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Baby Class
            Baby baby = new Baby(); // Empty 
            baby.PrintBaby();

            Console.WriteLine("--------------------------");

            // Create Baby Class
            Baby baby2 = new Baby("Murat", "Altınışık");
            baby2.PrintBaby();
        }
    }
}