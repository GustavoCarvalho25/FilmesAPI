using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "Campo Nome obrigatorio.")]
        [StringLength(50, ErrorMessage = "O nome nao pode ultrapassar 50 caracteres")]
        [NotNull]
        public string Nome { get; set; }
    }
}
