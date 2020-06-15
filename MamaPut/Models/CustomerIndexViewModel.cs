using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealApp.Entity;

namespace MamaPut.Models
{
    public class CustomerIndexViewModel
    {
        public int Id { get; set; }


        public string CustomerNumber { get; set; }
        public DateTime DateJoined  { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get; set; }

    }
}
