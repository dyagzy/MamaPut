using MamaPut.Models;
using MealApp.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamaPut.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public  IActionResult Index()
        {
            var customers = _customerService.GetAll().Select(customer => new CustomerIndexViewModel
            {
                FullName = customer.FullName,
               
                Email = customer.Email,
                Id = customer.Id,
                Phone = customer.Phone,
                CustomerNumber = customer.CustomerNumber,
                DateJoined = customer.DateJoined


            }).ToList();

            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
         public IActionResult Edit()
        {
            return View();
        }
        // public async Task <IActionResult> Edit()
        //{

            
        //    return View();
        //}
    }
}
