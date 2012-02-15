namespace IntroducaoAoMigrations.BancoDeDados.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Paises : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Paises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Sigla = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Paises");
        }
    }
}
