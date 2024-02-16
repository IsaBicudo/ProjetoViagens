using Microsoft.EntityFrameworkCore;

namespace ProjetoBancoDados.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }
        
        public DbSet<Cliente> Cliente { get; set;}
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Pacotes> Pacotes { get; set; }
        public DbSet<Transporte> Transporte { get; set; }
        public DbSet<TipoHospedagem> TipoHospedagem { get; set; }
        public DbSet<Hospedagem> Hospedagem { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Viagem> Viagem { get; set; }
    }
}
