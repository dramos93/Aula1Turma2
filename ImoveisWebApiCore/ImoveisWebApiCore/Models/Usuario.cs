using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisWebApiCore.Models 
{
    public class Usuario : ControleImovel
    {
        [Key]
        public int      Id      { get; set; }
        public string   Login   { get; set; }
        public string   Senha   { get; set; }
        

    }
}
