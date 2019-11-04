using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisWebApiCore.Models
{
    public class ControleImovel
    {

        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DtCriacao { get; set; } = DateTime.Now;
        public DateTime DtAlteracao { get; set; } = DateTime.Now;
    }
}

