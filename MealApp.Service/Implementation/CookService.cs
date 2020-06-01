using MealApp.Entity;
using MealApp2.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service.Implementation
{
    public class CookService : ICookService
    {
        private readonly ApplicationDbContext _context;

        public CookService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Cook cook)
        {
           await  _context.Cooks.AddAsync(cook);
           await  _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var cook = GetById(id);
            _context.Remove(cook);
           await  _context.SaveChangesAsync();
        }
       

        public IEnumerable<Cook> GetAll() => _context.Cooks.OrderBy(c => c.CookName);

        public Cook GetById(int CookId) => _context.Cooks.FirstOrDefault(c => c.Id == CookId);
       

        public async  Task UpdateAsync(int id)
        {
            var cook = GetById(id);
            _context.Update(cook);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cook cook)
        {
            _context.Update(cook);
            await _context.SaveChangesAsync();
        }
    }
}
