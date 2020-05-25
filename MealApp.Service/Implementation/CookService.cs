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
        public Task CreateAsync(Cook cook)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cook> GetAll() => _context.Cooks.OrderBy(c => c.CookName);

        public Cook GetById(int CookId) => _context.Cooks.FirstOrDefault(c => c.Id == CookId);
       

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cook cook)
        {
            throw new NotImplementedException();
        }
    }
}
