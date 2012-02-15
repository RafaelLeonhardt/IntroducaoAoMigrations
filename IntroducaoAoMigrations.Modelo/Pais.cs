using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroducaoAoMigrations.Modelo
{
    [Table("Paises")]
    public class Pais
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sigla { get; set; }

        public ICollection<Estado> Estados { get; set; }
    }
}
