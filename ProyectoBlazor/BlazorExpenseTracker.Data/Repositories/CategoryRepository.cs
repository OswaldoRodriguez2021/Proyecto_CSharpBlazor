using BlazorExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace BlazorExpenseTracker.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private SqlConfiguration _connectionString;

        public CategoryRepository(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        /*  System.Data.SqlClient instalar en Administrador de Paquetes Nuget
         *  tambien en este ejemplo se instala Dapper 
        */
        protected SqlConnection dbConnection()
        {
            /*return new SqlConnection(_connectionString.connectionString);*/
            return new SqlConnection("Data Source = DESKTOP-PC; Initial Catalog=BlazorExpenseTracker; Integrated Security = True");

        }
         
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var db = dbConnection();
            var sql = @"SELECT Id,Name FROM Categories";

            return await db.QueryAsync<Category>(sql, new { });
        }

        public async Task<Category> GetCategoryDetails(int Id)
        {
            var db = dbConnection();
            var sql = @"SELECT Id,Name 
                        FROM Categories 
                        WHERE Id = @Id";

            return await db.QueryFirstOrDefaultAsync<Category>(sql, new {Id=Id});
        }

        public async Task<bool> InsertCategory(Category category)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Categories (Name)
                        VALUES (@Name)  ";

            var result = await db.ExecuteAsync(sql, new { category.Name });
            return result > 0;
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            var db = dbConnection();
            var sql = @"UPDATE Categories 
                        SET    Name = @Name
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql, new { category.Name , category.Id});
            return result > 0;
        }
        public async Task<bool> DeleteCategory(int Id)
        {
            var db = dbConnection();
            var sql = @"DELETE FROM Categories 
                        WHERE Id = @Id";

            var result = await db.ExecuteAsync(sql, new { Id = Id });
            return result > 0;

        }
    }
}
