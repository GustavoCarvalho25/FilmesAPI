using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "Necessário preencher o titulo do filme")]
        [MaxLength(50, ErrorMessage = "O titulo nao pode ultrapassar 100 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Necessário preencher o genero do filme")]
        [MaxLength(50, ErrorMessage = "O genero nao pode ultrapassar 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Necessário preencher a duracao do filme")]
        [Range(70,600, ErrorMessage = "A duracao do filme deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "Necessário preencher o diretor do filme")]
        [MaxLength(50, ErrorMessage = "O nome do diretor nao pode ultrapassar 100 caracteres")]
        public string Diretor { get; set; }
    }
}
