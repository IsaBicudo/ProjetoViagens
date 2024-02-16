using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDados.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Código do Cliente")]
        public int ClienteId { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "Cpf")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClientePassaporte")]
        [Display(Name = "Passaporte")]
        public string ClientePassaporte { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEmail")]
        [Display(Name = "Email")]
        public string ClienteEmail { get; set; } = string.Empty;

        [Column("ClienteNascimento")]
        [Display(Name = "Nascimento")]
        public DateTime ClienteNascimento { get; set; }

    }
}

