using System.ComponentModel.DataAnnotations;
namespace Projetos_Filmes.Models;

public class Filme
{
    [Required]
    public int Id {get; set;}

    [Required(ErrorMessage ="Titulo é obrigatorio")] //Define o campo como obrigatorio
    [MaxLength(100, ErrorMessage ="Titulo não pode exceder 100 caracteres")]//define limite de caracteres
    public string? Titulo {get; set;}

    [Required]
    [Range(70, 400, ErrorMessage ="Duração não pode ser menor que 70 e não pode passar de 400")] //define limite de numeros 
    public string? Duracao {get; set;}
    
    public int Ano {get; set;}

    [Required]
    [MaxLength(50, ErrorMessage ="Genero não pode exceder 50 caracteres")]
    public string? Genero {get; set;}

    [Required]
    public string? Sinopse {get; set;}

    public List<string>? Elenco {get; set;}
    public string? Direcao {get; set;}
}