namespace IntroducaoAoMigrations.BancoDeDados.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Estados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaisId = c.Int(nullable: false),
                        Nome = c.String(nullable: false),
                        Sigla = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Paises", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);
        }
        
        public override void Down()
        {
            DropIndex("Estados", new[] { "PaisId" });
            DropForeignKey("Estados", "PaisId", "Paises");
            DropTable("Estados");
        }
    }
}
