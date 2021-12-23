using Microsoft.EntityFrameworkCore;

namespace ProvaGelaBahia.Models
{
    public class ProvaGelaBahiaContext: DbContext
    {
        public ProvaGelaBahiaContext(DbContextOptions<ProvaGelaBahiaContext> options): base (options)
        {
            
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoServico> TipoServico { get; set; }
    }
}