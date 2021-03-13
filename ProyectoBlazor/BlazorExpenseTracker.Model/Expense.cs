using BlazorExpenseTracker.Model.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorExpenseTracker.Model
{
    public class Expense //: IValidatableObject
    {

        public int id { get; set; }
        [Required]
        [Range(1, double.MaxValue,ErrorMessage ="El valor numerico debera ser entero ")]

        public decimal Amount { get; set; }
        [Required]
        public string CategoryID { get; set; }

        // [Required]
        public Category Category { get; set; }

        [Required]
        [ExpenseTransactionDateValidator(DaysInTheFuture =30)]
        public DateTime TransactionDate { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public event Action OnSelectedExpenseChanged;
        public void SelectedExpenseChange(Expense expense)
        {
            id = expense.id;
            TransactionDate = expense.TransactionDate;
            Amount = expense.Amount;
            ExpenseType = expense.ExpenseType;
            CategoryID = expense.CategoryID;

            NotifySelectedExpenseChanged();

        }

        private void NotifySelectedExpenseChanged()
        {
            OnSelectedExpenseChanged.Invoke();
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    var errors = new List<ValidationResult>();

        //    if (ExpenseType == ExpenseType.Income && Amount < 0)
        //    {
        //        errors.Add(new ValidationResult("La cantidad no puede ser menor a cero"
        //            , new[] { nameof(Amount) }));
        //    }
        //    else if (ExpenseType == ExpenseType.Expense && Amount > 0)
        //    {
        //        errors.Add(new ValidationResult("La cantida no pude ser mator a cero "
        //            , new[] { nameof(Amount) }));
        //    }
        //    return errors;
        //}
    }
}
