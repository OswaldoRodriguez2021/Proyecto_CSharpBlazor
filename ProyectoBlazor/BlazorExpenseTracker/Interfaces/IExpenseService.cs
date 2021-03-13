using BlazorExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExpenseTracker.Interfaces
{
    public interface IExpenseService
    {
        Task<IEnumerable<Expense>> GetAllExpense();
        Task<Expense> GetExpenseDetails(int id);
        Task SaveExpense(Expense expense);
        Task DeleteExpense(int id);

    }
}
