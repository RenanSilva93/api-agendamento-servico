using api_agendamento_servico.Data.Mappings;
using api_agendamento_servico.Models;
using Microsoft.EntityFrameworkCore;

namespace api_agendamento_servico.Data
{
    public class AgendamentoServicoDataContext : DbContext
    {
        public AgendamentoServicoDataContext(DbContextOptions<AgendamentoServicoDataContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
