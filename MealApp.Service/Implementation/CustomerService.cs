using MealApp.Entity;
using MealApp2.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async  Task CreateAsync(Customer customer)
        {
           await  _context.Customers.AddAsync(customer);
           await  _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var customer = GetById(id);
            _context.Remove(customer);
            await _context.SaveChangesAsync();
;        }

        public IEnumerable<Customer> GetAll() => _context.Customers.OrderBy(c => c.FirstName);


        public Customer GetById(int CustomerId) => _context.Customers.FirstOrDefault(c => c.Id == CustomerId);
        

        public async Task UpdateAsync(int id)
        {
            var customer = GetById(id);
            _context.Update(customer);
            await _context.SaveChangesAsync();
            
        }

        public async Task UpdateAsync(Customer customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}
