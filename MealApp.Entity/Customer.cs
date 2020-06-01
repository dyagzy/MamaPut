using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MealApp.Entity
{
    public class Customer
    {
        public int Id { get; set; }

    
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Display(Name= "Customer Number")]

        public string CustomerNumber { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        [Required, MaxLength(150)]
        public string Address { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }
        public DateTime DOB { get; set; }
        public string FullName
        {
            get
            {
                return FirstName   +  LastName;

            }

        }

        public MealSize MealSize { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DietRestriction DietRestriction { get; set; }

        public IEnumerable<Dish> Dishes { get; set; }
        [ForeignKey("CookId")]
        public int CookId { get; set; }
        public Cook Cook { get; set; }


    }
}
