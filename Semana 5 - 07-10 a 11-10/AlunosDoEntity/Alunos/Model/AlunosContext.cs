using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAlunos.Model
{
    public class AlunosContext : DbContext
    {
            public DbSet<Alunos> ListaAlunos { get; set; }


    }
}
