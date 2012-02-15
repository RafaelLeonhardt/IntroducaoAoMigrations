using System.ComponentModel.DataAnnotations;

namespace IntroducaoAoMigrations.Modelo
{
    [Table("Estados")]
    public class Estado
    {
        public int Id { get; set; }

        [Required, ForeignKey("PaisId")]
        public Pais Pais { get; set; }
        public int PaisId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sigla { get; set; }
    }
}
