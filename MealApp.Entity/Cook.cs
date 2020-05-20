using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MealApp.Entity
{
    public class Cook
    {
        public int Id { get; set; }
        [Required]
        public int CookId { get; set; }
        [Required]
        public string CookName { get; set; }
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
        public string ImageUrl { get; set; }
    }
}
