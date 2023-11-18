// William
using BancoAPI.Models;
using Microsoft.EntityFrameworkCore;
using Proejto_Banco.Models;

namespace BancoAPI.Data;

    public class BancoDbContext : DbContext
    {
        // Tabelas
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Seguro> Seguro { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        public DbSet<CartaoCredito> CartaoCredito { get; set; }
        public DbSet<Investimento> Investimento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=banco.db;Cache=Shared");
        }
    }
