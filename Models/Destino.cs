using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Column("DestinoId")]
        [Display(Name = "Código do Destino")]
        public int DestinoId { get; set; }

        [Column("DestinoNome")]
        [Display(Name = "Destino")]
        public string DestinoNome { get; set; } = string.Empty;
    }
}
