using MealApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        Task CreateAsync();
        Task UpdateAsync(int id);
        Task UpdateAsync(Customer customer);
        Task Delete(int id);

    }
}
