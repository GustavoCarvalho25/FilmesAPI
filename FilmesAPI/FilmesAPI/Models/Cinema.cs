using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário preencher o nome do cinema")]
        [MaxLength(50)]
        [NotNull]
        public string Nome { get; set; }

    }
}
