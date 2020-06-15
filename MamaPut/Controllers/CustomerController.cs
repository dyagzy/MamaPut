using MamaPut.Models;
using MealApp.Entity;
using MealApp.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MamaPut.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CustomerController(ICustomerService customerService, IHostingEnvironment hostingEnvironment)
        {
            _customerService = customerService;
            _hostingEnvironment = hostingEnvironment;
        }

        public  IActionResult Index()
        {
            var customers = _customerService.GetAll().Select(customer => new CustomerIndexViewModel
            {
                FullName = customer.FullName,
               
                Email = customer.Email,
                ImageUrl = customer.ImageUrl,
                Id = customer.Id,
                Phone = customer.Phone,
                CustomerNumber = customer.CustomerNumber,
                DateJoined = customer.DateJoined


            }).ToList();

            return View(customers);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Email = model.Email,
                    CustomerNumber = model.CustomerNumber,
                    DateJoined = model.DateJoined,
                    FullName = model.FullName,
                    MiddleName = model.MiddleName,
                    Phone = model.Phone,
                    DOB = model.DOB,
                    DietRestriction = model.DietRestriction,
                    PaymentMethod = model.PaymentMethod,
                    MealSize = model.MealSize,
                    

                };
                if (model.ImageUrl != null && model.ImageUrl.Length > 0)
                {
                    var uploadDir = @"images/customer";
                    var fileName = Path.GetFileNameWithoutExtension(model.ImageUrl.FileName);
                    var extension = Path.GetExtension(model.ImageUrl.FileName);
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    fileName = DateTime.UtcNow.ToString("yyyymmssff") + fileName + extension;
                    var path = Path.Combine(uploadDir, webRootPath, fileName);
                   await  model.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    customer.ImageUrl = "/" + "/" + uploadDir + fileName;



                }
               await  _customerService.CreateAsync(customer);
                return RedirectToAction(nameof(Index));

                
            }
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
