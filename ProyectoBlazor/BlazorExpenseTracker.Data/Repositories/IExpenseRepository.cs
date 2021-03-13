using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlazorExpenseTracker.Model;

namespace BlazorExpenseTracker.Data.Repositories
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetAllExpense();
        Task<Expense> GetExpenseDetails(int id);
        Task<bool> InsertExpenseDetails(Expense expense);
        Task<bool> UpdateExpense(Expense expense);
        Task<bool> DeleteExpense(int id);
     
    }
}
