using System;
using System.Collections.Generic;
using System.Text;
using BlazorExpenseTracker.Model;
using System.Threading.Tasks;

namespace BlazorExpenseTracker.Data.Repositories
{
    public interface ICategoryRepository
    {

        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryDetails(int Id);
        Task<bool> InsertCategory(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int Id);

    }
}
