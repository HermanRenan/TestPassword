using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Senhas.Validators
{
    public class AmountCharacter : ValidationAttribute
    {
        
        public AmountCharacter() : base("{0} Quantidade de caracteres deve ser no mínimo 9")
        {            
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                var valueAsString = value.ToString();
                if(valueAsString.Length < 9)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}