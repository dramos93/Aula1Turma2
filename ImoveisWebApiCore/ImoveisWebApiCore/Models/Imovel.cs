using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisWebApiCore.Models
{
    public class Imovel : ControleImovel
    {
        [Key]
        public int       Id             { get; set; }
        public string    Logradouro     { get; set; }
        public string   Bairro          { get; set; }
        public string   Cep             { get; set; }
        public string   Municipio       { get; set; }
        public string   Uf              { get; set; }
        public double   Valor           { get; set; }
        public int      IdProprietario  { get; set; }
        public string   Complemento     { get; set; }
        public int   IdUsuario       { get; set; }

    }
}
