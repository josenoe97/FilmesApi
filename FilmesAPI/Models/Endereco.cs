using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string  Logadouro { get; set; }
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; } // isto diz que é uma relação de possui apenas um endereço 1:1
    }
}
