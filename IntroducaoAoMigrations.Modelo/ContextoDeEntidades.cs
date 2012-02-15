using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IntroducaoAoMigrations.Modelo
{
    public class ContextoDeEntidades : DbContext
    {
        DbSet<Pais> Paises { get; set; }
        DbSet<Estado> Estados { get; set; }
    }
}
