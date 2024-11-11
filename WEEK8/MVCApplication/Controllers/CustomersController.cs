using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers;

public class CustomersController : Controller
{
    public IActionResult Index()
    {
        CustomerViewModel customerViewModel = new CustomerViewModel();

        customerViewModel.Customer = new Customer
        {
            Id = 1,
            FirstName = "Murat",
            LastName = "Altınışık",
            Email = "altinisikmurat@gmail.com",
        };

        customerViewModel.WelcomeMessage = "Welcome to our customer portal!";

        return View(customerViewModel);
    }
}