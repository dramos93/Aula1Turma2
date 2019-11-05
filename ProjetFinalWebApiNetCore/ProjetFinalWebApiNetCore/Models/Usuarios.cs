using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ProjetFinalWebApiNetCore.Models
{
    public partial class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
