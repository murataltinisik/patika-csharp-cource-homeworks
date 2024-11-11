using EndMVCApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndMVCApplication.Controllers;

public class CustomerOrdersController : Controller
{
    public IActionResult Index()
    {
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Murat",
            LastName = "Altınışık",
            Email = "altinisikmurat@gmail.com"
        };

        List<Order> orders = new List<Order>
        {
            new Order() { Id = 1, ProductName = "iPhone 16", Price = 60000.00m, Quantity = 10},
            new Order() { Id = 2, ProductName = "Macbook M3 Pro", Price = 120000m, Quantity = 5}
        };

        CustomerOrderViewModel customerOrderViewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(customerOrderViewModel);
    }
}