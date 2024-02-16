using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Pacotes")]
    public class Pacotes
    {
        [Column("PacotesId")]
        [Display(Name = "Código dos Pacotes")]
        public int PacotesId { get; set; }

        [Column("PacotesNome")]
        [Display(Name = "Pacotes")]
        public string PacotesNome { get; set; } = string.Empty;
    }
}
