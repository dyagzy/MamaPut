using MealApp.Entity;
using MealApp2.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service.Implementation
{
    public class DishService : IDishService
    {
        private readonly ApplicationDbContext _context;

        public DishService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Dish dish)
        {
            await _context.Dishes.AddAsync(dish);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int dishId)
        {
            var dish = GetById(dishId);
            _context.Remove(dish);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Dish> GetAll() => _context.Dishes;


        public Dish GetById(int dishId) => _context.Dishes.Where(d => d.Id == dishId).FirstOrDefault();


        public async Task UpdateAsync(Dish dish)
        {
            _context.Update(dish);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var dish = GetById(id);
            _context.Dishes.Update(dish);
            await _context.SaveChangesAsync();
        }
    }
}