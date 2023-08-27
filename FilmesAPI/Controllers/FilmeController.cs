using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;

    public FilmeController(FilmeContext context) // Aplicação direta no BD 
    {
        _context = context;
    }


    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme) // Ação de Inserção de recurso no sistema
    {
        /*filme.Id = id++;
        filmes.Add(filme);*/
        _context.Filmes.Add(filme);
        _context.SaveChanges(); // Salva alterações 

        // retorna o caminho que foi cadastrado
        return CreatedAtAction(nameof(RecuperaFilmePorId),
            new {id = filme.Id } , 
            filme);

    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50) // Ação de Leitura
    {
        /*return filmes.Skip(skip).Take(take);*/
        return _context.Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public  IActionResult RecuperaFilmePorId(int id)
    {
        /*var filme = filmes.FirstOrDefault(filme => filme.Id == id);*/
        var filme = _context.Filmes
            .FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound(); // returna caso a pagina não exista
        return Ok(filme);
        
    }
}
