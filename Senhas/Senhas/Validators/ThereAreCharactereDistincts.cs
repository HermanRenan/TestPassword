using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Senhas.Validators
{
    public class ThereAreCharactereDistincts : ValidationAttribute
    {
        public ThereAreCharactereDistincts() : base("{0} Não deve possuir caracteres repetidos")
        {
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                List<char> listCaractereString = new List<char>();

                foreach (var item in valueAsString)
                {
                    if (listCaractereString.Contains(item))
                    {
                        var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(errorMessage);
                    }
                    else
                        listCaractereString.Add(item);
                }
            }

            return ValidationResult.Success;
        }
    }
}