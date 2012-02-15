namespace IntroducaoAoMigrations.BancoDeDados.Migrations
{
    using System.Data.Entity.Migrations;
    using IntroducaoAoMigrations.Modelo;

    internal sealed class Configuration : DbMigrationsConfiguration<ContextoDeEntidades>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContextoDeEntidades context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
