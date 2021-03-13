using BlazorExpenseTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BlazorExpenseTracker.Data.Repositories;

namespace BlazorExpenseTracker.Data.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private SqlConfiguration _connectionString;
        public ExpenseRepository(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        //protected SqlConnection dbConnection()
        //{
        //    return new SqlConnection(_connectionString.connectionString);
        //}

        protected SqlConnection dbConnection()
        {
            /*return new SqlConnection(_connectionString.connectionString);*/
            return new SqlConnection("Data Source = DESKTOP-PC; Initial Catalog=BlazorExpenseTracker; Integrated Security = True");

        }
        public async Task<bool> DeleteExpense(int id)
        {
            var db = dbConnection();
            var sql = @"DELETE FROM Expenses WHERE Id = @Id";
            var result = await db.ExecuteAsync(sql, new { id });
            return result > 0;
        }

        public async Task<IEnumerable<Expense>> GetAllExpense()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT e.Id, Amount , CategoryId
                      , ExpenseType, Transactiondate, c.Id, c.name 
                        FROM Expenses e 
                            INNER JOIN Categories c ON CategoryId = c.Id ";

            var result = await db.QueryAsync<Expense, Category, Expense>(sql,
                ((expense, category) =>
                   {
                       expense.Category = category;
                       return expense;
                   }), new { }, splitOn: "Id");

            return result;
            //var sql = @"
            //            SELECT Id, Amount , CategoryId, ExpenseType, Transactiondate 
            //            FROM Expenses  
            //                ";

            //return await db.QueryAsync<Expense>(sql, new { });



        }

        public  async Task<Expense> GetExpenseDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT Id, Amount, CategoryId, ExpenseType, TransactionDate
                        FROM Expenses 
                        WHERE Id = @Id ";
            return await db.QueryFirstOrDefaultAsync<Expense>(sql, new { Id = id });
        }

        public async Task<bool> InsertExpenseDetails(Expense expense)
        {
            int num = 1;
            var db = dbConnection();
            var sql = @" INSERT INTO Expenses ([Amount],[CategoryId],[ExpenseType],[TransactionDate])
                         VALUES (@Amount,@CategoryId,@ExpenseType,@TransactionDate) ";

            //var sql = @" INSERT INTO Expenses ([Amount],[CategoryId],[ExpenseType],[TransactionDate])
            //             VALUES (2250,'1','1','2021-01-01') ";

            var result = await db.ExecuteAsync(sql,
            new { expense.Amount, expense.CategoryID, expense.ExpenseType , expense.TransactionDate });

            return result > 0;

        }
        public async Task<bool> UpdateExpense(Expense expense)
        {
            var db = dbConnection();

            var sql = @" 
                         UPDATE Expenses
                         SET Amount = @Amount
                         ,CategoryId = @CategoryId
                         ,ExpenseType = @ExpenseType
                         ,TransactionDate = @TransactionDate
                         WHERE Id= @Id
                      ";

            var result = await db.ExecuteAsync(sql,
            new
            {
                  expense.id
                , expense.Amount
                , expense.CategoryID
                , expense.ExpenseType
                , expense.TransactionDate

             });

            return result > 0;

        }

     
    }
}
