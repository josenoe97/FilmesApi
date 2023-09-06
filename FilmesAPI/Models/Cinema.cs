using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; } //FK

        public virtual Endereco Endereco { get; set; } // isto diz que é uma relação de possui apenas um endereço 1:1 
        // gera um instancia Possibilitando puxar logradoura e numero

        public virtual ICollection<Sessao> Sessoes { get; set; }

    }
}
