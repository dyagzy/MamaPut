using MealApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service
{
    public interface IDishService
    {
        IEnumerable<Dish> GetAll();
        Dish GetById(int dishId);
        Task Delete(int dishId);
        Task UpdateAsync(int id);
        Task UpdateAsync(Dish dish);

        Task CreateAsync(Dish dish);

    }
}
