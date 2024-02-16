using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("TipoHospedagem")]
    public class TipoHospedagem
    {
        [Column("TipoHospedagemId")]
        [Display(Name = "Código do Tipo Hospedagem")]
        public int TipoHospedagemId { get; set; }

        [Column("TipoHospedagemNome")]
        [Display(Name = "Tipo Hospedagem")]
        public string TipoHospedagemNome { get; set; } = string.Empty;
    }
}
