using MealApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int CustomerId);
        Task CreateAsync(Customer customer);
        Task UpdateAsync(int id);
        Task UpdateAsync(Customer customer);
        Task Delete(int id);

    }
}
