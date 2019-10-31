namespace RegistroImoveis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProprietarioTypeAndValorImovelAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovels", "ValorDoImovel", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Imovels", "Proprietario", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Imovels", "Proprietario", c => c.String());
            DropColumn("dbo.Imovels", "ValorDoImovel");
        }
    }
}
