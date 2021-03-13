using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorExpenseTracker.Model;

namespace BlazorExpenseTracker.Interfaces
 {
    public interface ICategoriService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryDetails(int id);
        Task SaveCategory(Category category);
        // Task<bool> UpdateCategory(Category category);
        Task DeleteCategory(int id);
    } 
} 
