using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorExpenseTracker.Model.Validation
{
    public class ExpenseTransactionDateValidator: ValidationAttribute 
    {
        public int DaysInTheFuture { get; set; } 
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime transactionDate;
            
            if(DateTime.TryParse(value.ToString(), out transactionDate))
            {
                if(transactionDate == DateTime.MinValue)
                {
                    return new ValidationResult($"La fecha ingresada no puede ser vacia ",
                           new[] { validationContext.MemberName });
                }
                else if(transactionDate > DateTime.Now.AddDays(DaysInTheFuture))
                {
                    return new ValidationResult($"La fecha no puedde ser mayor a hoy mas 30 dia ",
                           new[] { validationContext.MemberName });
                }
                return null;
            }

            return new ValidationResult("fecha Invalida ",
                   new[] { validationContext.MemberName } );
        }
    }
}
