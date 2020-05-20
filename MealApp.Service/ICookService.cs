using MealApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MealApp.Service
{
    public interface ICookService
    {

        IEnumerable<Cook> GetAll();
        Cook GetById(int CookId);
        Task CreateAsync(Cook cook);
        Task UpdateAsync(int id);
        Task UpdateAsync(Cook cook);
        Task Delete(int id);

    }
}
