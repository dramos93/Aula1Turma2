using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFloricultura.Model
{
    public class FloresContext : DbContext
    {
        public DbSet<Flores> Flor {get; set;}
    }
}
