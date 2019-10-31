using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        MigrationsContext db = new MigrationsContext();
        private string FildName { get; set; }

        public CustomValidator(string Field)
        {
            FildName = Field;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (FildName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                {
                    return new ValidationResult("Usuário já existe");
                }
                if (value.ToString().Contains("Giomar"))
                {
                    return new ValidationResult("Não é possível registrar novamente");

                }
            }

            if (FildName == "DataNascimento")
            {
                if (((DateTime.Now.Year -  (DateTime.Parse(value.ToString()).Year)) > 150)) 
                {
                    return new ValidationResult("Tais Muito Velho");
                }
                if (((DateTime.Now.Year -  (DateTime.Parse(value.ToString()).Year)) < 18))
                {
                    return new ValidationResult("Tais Muito Novo, não é possível Registrar");
                }
            }
                       
            /*Método Professor*/
            if (validationContext.DisplayName == "DataNascimento")
            {
                var dataInformada = DateTime.Parse(value.ToString());
                var idade = DateTime.Now.Year - dataInformada.Year;
                if (idade <= 18)
                {
                    return new ValidationResult("É Preciso ser maior ou igual a 18!");
                }
                if (idade > 150)
                {
                    return new ValidationResult("É Preciso ser menor a 150!");
                }
            }
             /**/

            return ValidationResult.Success;
        }

    }
}