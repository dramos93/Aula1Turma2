using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomes.Model
{
    public class NomesContext : DbContext
    {
        public DbSet<Name> GetNomes {get; set;}
    }
}
