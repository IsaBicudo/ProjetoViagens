using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Transporte")]
    public class Transporte
    {
        [Column("TransporteId")]
        [Display(Name = "Código do Transporte")]
        public int TransporteId { get; set; }

        [Column("TransporteNome")]
        [Display(Name = "Transporte")]
        public string TransporteNome { get; set; } = string.Empty;

        [Column("TransporteAno")]
        [Display(Name = "Ano")]
        public DateTime TransporteAno { get; set; }

        [Column("TransportePlaca")]
        [Display(Name = "Placa")]
        public string TransportePlaca { get; set; } = string.Empty;
    }
}
