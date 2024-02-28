using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "Necessario preencher o nome do cinema")]
        public string Nome { get; set; }
    }
}
