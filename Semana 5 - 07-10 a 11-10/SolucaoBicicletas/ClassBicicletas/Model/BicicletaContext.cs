using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBicicletas.Model
{
    public class BicicletaContext : DbContext
    {
        public DbSet<Bicicleta> bicicletas { get; set; }
    }
}
