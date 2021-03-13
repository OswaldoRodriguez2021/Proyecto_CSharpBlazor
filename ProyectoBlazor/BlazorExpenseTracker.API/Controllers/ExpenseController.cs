using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorExpenseTracker.Data.Repositories;
using BlazorExpenseTracker.Model;

namespace BlazorExpenseTracker.API.Controllers
{
    [Route("api/expense")]
    [ApiController]
    public class ExpenseController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseController(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllExpense() 
        {
            return Ok(await _expenseRepository.GetAllExpense());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseDetals(int id) 
        {
            return Ok(await _expenseRepository.GetExpenseDetails(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateExpense([FromBody] Expense expense)
        {
            if (expense == null) 
            {
                return BadRequest();
            }

            if(expense.Amount < 0)
            {
                ModelState.AddModelError("Name", "la cantidad no debe estar vacía"); 
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            var created = await _expenseRepository.InsertExpenseDetails(expense);
            return Created("created", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateExpense([FromBody] Expense expense) 
        {
            if (expense == null)
            {
                return BadRequest();
            }

            if (expense.Amount < 0)
            {
                ModelState.AddModelError("Name", "la cantidad no debe estar vacía");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _expenseRepository.UpdateExpense(expense);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id == 0)
                return BadRequest();
            await _expenseRepository.DeleteExpense(id);

            return NoContent();
        }

    }
}
