using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.ContextDb
{
    public class DBContext :DbContext
    {
        public DbSet<Genero> Genero { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Beneficio> Beneficio { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<ContratoTrabalho> ContratoTrabalho { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Escala> Escala { get; set; }
        public DbSet<EspacoCliente> EspacoCliente { get; set; }
        public DbSet<LogAgendamento> LogAgendamento { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<RegimeContratual> RegimeContratual { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MIR-0550;" +
                "Initial Catalog=TechBeauty;Integrated Security=true");
        }
    }
}
