using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MealApp.Entity
{
    public class Dish
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string DishName { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Price { get; set; }
        [MaxLength(300)]
        public MealType MealType { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Prepared")]

        public DateTime DatePrepared { get; set; } = DateTime.UtcNow;
        [Display(Name = "Weight of Dish")]
        public string DishMass { get; set; }
        public string ImageUrl { get; set; }

        [Required, MaxLength(50)]
        public string DietInfo { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [ForeignKey("CookId")]
        public int CookId { get; set; }
        public Cook Cook { get; set; }
        [ForeignKey("Customer Details")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
