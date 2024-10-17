using OOP;

namespace _07Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define Employees
            Employee softwareDeveloper = new SoftwareDeveloper("Murat", "Altınışık", "IT");
            Employee projectManager = new ProjectManager("Hasan", "Çıldırmış", "Management");
            Employee salesRepresentative = new SalesRepresentative("Grals", "Reis", "Sales");

            // Print Get Task
            softwareDeveloper.GetTask();
            projectManager.GetTask();
            salesRepresentative.GetTask();
        }
    }
}