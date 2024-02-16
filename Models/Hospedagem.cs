using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Hospedagem")]
    public class Hospedagem
    {
        [Column("HospedagemId")]
        [Display(Name = "Código da Hospedagem")]
        public int HospedagemId { get; set; }

        [Column("HospedagemNome")]
        [Display(Name = "Hospedagem")]
        public string HospedagemNome { get; set; } = string.Empty;

        [ForeignKey("TipoHospedagemId")]
        public int TipoHospedagemId { get; set; }

        public TipoHospedagem? TipoHospedagem { get; set; }

        [ForeignKey("DestinoId")]
        public int DestinoId { get; set; }

        public Destino? Destino { get; set; }

        [Column("HospedagemLocal")]
        [Display(Name = "Local")]
        public string HospedagemLocal { get; set; } = string.Empty;
    }
}
