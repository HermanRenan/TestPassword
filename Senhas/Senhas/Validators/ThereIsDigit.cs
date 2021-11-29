using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Senhas.Validators
{
    public class ThereIsDigit : ValidationAttribute
    {
        public ThereIsDigit() : base("{0} Tem que ter pelo menos 1 dígito")
        {           
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {                
                var valueAsString = value.ToString();

                if (!(Regex.IsMatch(valueAsString, @"\d"))) 
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}