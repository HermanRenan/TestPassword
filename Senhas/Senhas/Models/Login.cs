using Senhas.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Senhas.Models
{
    public class Login
    {        
        [AmountCharacter]
        [CharacterSpecial("!@#$%^&*()-+")]
        [ThereIsDigit]
        [ThereIsUpperCase]
        [ThereIsLowerCase]
        [ThereAreCharactereDistincts]
        [Display(Name ="Senha: ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress(ErrorMessage = "Favor preencher um endereço de Email válido")]
        public string Email { get; set; }
    }
}