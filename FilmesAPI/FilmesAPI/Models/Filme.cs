using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário preencher o titulo do filme")]
        [MaxLength(50)]
        [NotNull]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Necessário preencher o genero do filme")]
        [MaxLength(50)]
        [NotNull]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Necessário preencher a duracao do filme")]
        [Range(70,600)]
        [NotNull]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "Necessário preencher o diretor do filme")]
        [MaxLength(50)]
        [NotNull]
        public string Diretor { get; set; }
    }
}
