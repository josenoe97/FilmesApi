﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Sessao
{
    [Key]
    [Required]
    public int Id { get; set; }

    public int? FilmeId { get; set; }
    
    public virtual Filme Filme { get; set; }//uma sessao pode ter um filme
    
    public int? CinemaId { get; set; }   

    public virtual Cinema Cinema { get; set; }

}
