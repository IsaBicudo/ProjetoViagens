using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Column("PagamentoId")]
        [Display(Name = "Código do Pagamento")]
        public int PagamentoId { get; set; }

        [Column("PagamentoNome")]
        [Display(Name = "Forma de Pagamento")]
        public string PagamentoNome { get; set; } = string.Empty;
    }
}
