using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Se agrego lo siguiente
using System.Text.Json;
using BlazorExpenseTracker.Model;
using BlazorExpenseTracker.Interfaces;
using System.Net.Http;
using System.Text;


namespace BlazorExpenseTracker.Services
{
    public class ExpenseServices : IExpenseService
    {

        private readonly HttpClient _httpClient;

        public ExpenseServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task DeleteExpense(int id)
        {
            await _httpClient.DeleteAsync($"api/expense/{id}"); 
        }

        public async Task<IEnumerable<Expense>> GetAllExpense()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Expense>>(
                   await _httpClient.GetStreamAsync($"api/expense"),
                   new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async  Task<Expense> GetExpenseDetails(int id)
        {
            return await JsonSerializer.DeserializeAsync<Expense>(
                   await _httpClient.GetStreamAsync($"https://localhost:44324/api/expense/" + id),
                   new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
              
        }

        public async Task SaveExpense(Expense expense)
        {
            var expenseJson = new StringContent(JsonSerializer.Serialize(expense), Encoding.UTF8,
                "application/json");

            if (expense.id == 0)
                await _httpClient.PostAsync("https://localhost:44324/api/expense", expenseJson); // Agregar Expense
            else
                await _httpClient.PutAsync("https://localhost:44324/api/expense", expenseJson); // Modificar Expense
        }
    }
}
