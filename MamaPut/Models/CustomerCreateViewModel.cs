using MealApp.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MamaPut.Models
{
    public class CustomerCreateViewModel
    {

        public int Id { get; set; }


        [Required (ErrorMessage ="First Name is  required"), StringLength(50, MinimumLength =2)]
        [RegularExpression(@"[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Fisrt Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName  + (string.IsNullOrEmpty(MiddleName) ? "  " : (" " +(char?)MiddleName[0]  + " . " ).ToUpper()) + LastName;

            }

        }
        [Display(Name = "Customer Number")]
        [Required(ErrorMessage = "Employee Number is required"),
            RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string CustomerNumber { get; set; }
        [Required]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }

        [Required, MaxLength(150)]
        public string Address { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        [DataType(DataType.Date), Display(Name =" Date of Birth")]
        public DateTime DOB { get; set; } 
        [Display(Name ="Meal Size")]
       
        public MealSize MealSize { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Diet Restriction")]
        public DietRestriction DietRestriction { get; set; }


    }
}
