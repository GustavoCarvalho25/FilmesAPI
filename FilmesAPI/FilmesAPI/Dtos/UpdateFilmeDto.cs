using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmesAPI.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "Necessário preencher o titulo do filme")]
        [StringLength(50, ErrorMessage = "O titulo nao pode ultrapassar 100 caracteres")]
        [NotNull]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Necessário preencher o genero do filme")]
        [StringLength(50, ErrorMessage = "O genero nao pode ultrapassar 50 caracteres")]
        [NotNull]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Necessário preencher a duracao do filme")]
        [Range(70, 600, ErrorMessage = "A duracao do filme deve ser entre 70 e 600 minutos")]
        [NotNull]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "Necessário preencher o diretor do filme")]
        [StringLength(50, ErrorMessage = "O nome do diretor nao pode ultrapassar 100 caracteres")]
        [NotNull]
        public string Diretor { get; set; }
    }
}
