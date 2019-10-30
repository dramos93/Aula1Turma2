using ConsoleMigrations.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMigrations
{
    class Program
    {
        static MigrationsContext db = new MigrationsContext();

        static void Main(string[] args)
        {
            //Iniciamos nossa base de dados
            db.Usuarios.ToList().ForEach(x => System.Console.WriteLine(x.Nome));


        }
    }
}
