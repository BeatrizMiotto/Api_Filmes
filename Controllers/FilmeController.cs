using Microsoft.AspNetCore.Mvc;
using Projetos_Filmes.Models;

namespace Projetos_Filmes.Controllers;

[ApiController]
[Route("[Controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filmes.Add(filme);
        Console.WriteLine(filme.Ano);
        Console.WriteLine(filme.Titulo);
    }

}