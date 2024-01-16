using CustomersAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<customer> customers;

        public CustomerController() {

            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Tim", 12));
            customers.Add(new Customer(2, "Charlene", 98));
            customers.Add(new Customer(3, "Dane", 24));
            customers.Add(new Customer(4, "Elijah", 51));
            customers.Add(new Customer(5, "Howard", 64));
            customers.Add(new Customer(6, "Dave", 34));
        }


        // GET: Customer
        public ActionResult Index()
        {


            return View("Customer");

        }

    }
}