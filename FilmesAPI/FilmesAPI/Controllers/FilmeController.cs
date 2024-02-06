using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        private static int id = 0;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(
                nameof(RetornaFilmePorId),
                new { id = filme.Id},
                filme
            );
        }

        [HttpGet]
        public IEnumerable<Filme> RetornaFilmes
        (
            [FromQuery] int skip = 0,
            [FromQuery] int take = 30
        )
        {
            return _context.Filmes.Skip(skip).Take(take);
        }

        [HttpGet("{Id}")]
        public IActionResult RetornaFilmePorId(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }
    }
}
