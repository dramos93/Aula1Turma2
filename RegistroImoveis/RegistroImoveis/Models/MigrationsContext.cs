namespace RegistroImoveis.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MigrationsContext : DbContext
    {
        // Your context has been configured to use a 'MigrationsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RegistroImoveis.Models.MigrationsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MigrationsContext' 
        // connection string in the application configuration file.
        public MigrationsContext()
            : base("name=MigrationsContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Imovel> Imovels { get; set; }
        public virtual DbSet<Proprietarios> Proprietarios { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}