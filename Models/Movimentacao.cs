using System;
using System.ComponentModel.DataAnnotations;

namespace BancoAPI.Models;
    public enum TipoMovimentacao
    {
        Saque,
        Deposito
    }

    public class Movimentacao
    {
        [Key]
        public int Id { get; set; }
        public TipoMovimentacao Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataMovimentacao { get; set; }
        
        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }
    }