using BlazorExpenseTracker.Interfaces;
using BlazorExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;
using System.Xml.Linq;

namespace BlazorExpenseTracker.Services
{ 
    public class CategoryService : ICategoriService
    {
        private readonly HttpClient _HttpClient;

        public CategoryService(HttpClient httpClient) 
        {
            _HttpClient = httpClient;
        }
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
           
            return await JsonSerializer.DeserializeAsync<IEnumerable<Category>>
                (
                   await _HttpClient.GetStreamAsync("https://localhost:44324/api/controller/"),
                   new JsonSerializerOptions() {PropertyNameCaseInsensitive = true}
                );

        }
        public async Task<Category> GetCategoryDetails(int id)
        {
            return await JsonSerializer.DeserializeAsync<Category>
                (
                   await _HttpClient.GetStreamAsync("https://localhost:44324/api/controller/" + id),
                   new JsonSerializerOptions() {PropertyNameCaseInsensitive = true}
                 
                  /**
                   await _HttpClient.GetStreamAsync($"api/category/{id}"),
                   new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }
                  **/
                );
        }



        public async Task SaveCategory(Category category)
        {
            var categoryJson = new StringContent(JsonSerializer.Serialize(category),
                Encoding.UTF8, "application/json");

                                                              
            if (category.Id == 0)   
               await _HttpClient.PostAsync("https://localhost:44324/api/controller", categoryJson); // Post Se utiliza para grabar una categoria
            else
               await _HttpClient.PutAsync("https://localhost:44324/api/controller", categoryJson); // Put se utiliza para modificar la categoria       
        }

        public async Task DeleteCategory(int id)
        {
            /**
            await _HttpClient.DeleteAsync($"api/category/{id}");
            **/

            await _HttpClient.DeleteAsync("https://localhost:44324/api/controller/" + id);

        }

    }
} 
