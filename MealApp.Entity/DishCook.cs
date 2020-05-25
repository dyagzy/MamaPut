using System;
using System.Collections.Generic;
using System.Text;

namespace MealApp.Entity
{
    public class DishCook
    {
        public int DishId { get; set; }
        public Dish  Dish { get; set; }
        public int CookId { get; set; }
        public Cook Cook { get; set; }


    }
}
