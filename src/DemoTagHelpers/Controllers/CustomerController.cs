using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoTagHelpers.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(bool isReadonly = false)
        {
            var customer = new Models.Customer();
            customer.AddressLine1 = "Microsoft France";
            customer.AddressLine2 = "39 Quai du Président Roosevelt";
            customer.City = "Issy-les-Moulineaux";
            customer.Country = "France";
            customer.FirstName = "Julien";
            customer.Id = Guid.NewGuid();
            customer.IsReadonly = isReadonly;
            customer.LastName = "Corioland";
            customer.Title = "Mr.";
            customer.ZipCode = "92130";

            return View(customer);
        }

        // GET: /<controller>/
        public IActionResult Index2(bool isReadonly = false)
        {
            var customer = new Models.Customer();
            customer.AddressLine1 = "Microsoft France";
            customer.AddressLine2 = "39 Quai du Président Roosevelt";
            customer.City = "Issy-les-Moulineaux";
            customer.Country = "France";
            customer.FirstName = "Julien";
            customer.Id = Guid.NewGuid();
            customer.IsReadonly = isReadonly;
            customer.LastName = "Corioland";
            customer.Title = "Mr.";
            customer.ZipCode = "92130";

            return View(customer);
        }
    }
}
