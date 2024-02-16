using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Viagem")]
    public class Viagem
    {
        [Column("ViagemId")]
        [Display(Name = "Código da Viagem")]
        public int ViagemId { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("´PacotesId")]
        public int PacotesId { get; set; }

        public Pacotes? Pacotes { get; set; }

        [ForeignKey("HospedagemId")]
        public int HospedagemId { get; set; }

        public Hospedagem? Hospedagem { get; set; }

        [ForeignKey("TransporteId")]
        public int TransporteId { get; set; }

        public Transporte? Transporte { get; set; }


        [Column("ViagemData")]
        [Display(Name = "Data")]
        public DateTime ViagemData { get; set; }

        [Column("ViagemValor")]
        [Display(Name = "Valor Total")]
        public Decimal ViagemValor { get; set; }

        [ForeignKey("PagamentoId")]
        public int PagamentoId { get; set; }

        public Pagamento? Pagamento { get; set; }
    }
}