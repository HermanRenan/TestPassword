using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Senhas.Validators
{
    public class CharacterSpecial : ValidationAttribute
    {
        private readonly string _char;
        public CharacterSpecial(string _char) : base("{0} Deve haver no Password ao menos 1 desses caractéres: !@#$%^&*()-+")
        {
            this._char = _char;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {                
                var valueAsString = value.ToString();
                foreach (var item in _char)
                {
                    if(valueAsString.Contains(item))
                        return ValidationResult.Success;
                }                
            }

            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }
    }
}