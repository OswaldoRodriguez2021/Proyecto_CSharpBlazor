﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlazorExpenseTracker.Data.Repositories;
using BlazorExpenseTracker.Model;

namespace BlazorExpenseTracker.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet] /* Se escribe un HttpGet para ser accesible por un http request de nuestra api 
                     en este ejemplo con el Get se utiliza para consultar datos de una tabla 
                   */
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryRepository.GetAllCategories());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryDetails(int id)
        {
            return Ok(await _categoryRepository.GetCategoryDetails(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            /*
                if (category == null)
                    return BadRequest();

                if (category.Name.Trim() == string.Empty)
                {
                    ModelState.AddModelError("Name", "Category Name vacio (Emty) ");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
            */

            var created = await _categoryRepository.InsertCategory(category);

            return Created("Created", created);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            if (category.Name.Trim() == string.Empty)
            {
                ModelState.AddModelError("Name", "Category Name vacio (Emty) ");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _categoryRepository.UpdateCategory(category);

            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            if (Id == 0)
                return BadRequest();

            await _categoryRepository.DeleteCategory(Id);
            return NoContent();

        }
       
    }
}
