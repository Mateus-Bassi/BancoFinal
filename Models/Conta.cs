// William Dalla Stella dos Santos
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BancoAPI.Models;
    public enum TipoConta
    {
        Poupanca,
        Corrente,
        Salario
    }

    public class Conta
    {
        // Chave Primária
        [Key]
        public int Id { get; set; }

        public string NumeroConta { get; set; }
        public TipoConta TipoConta { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        // Chaves estrangeiras
        public int ClienteId { get; set; } 
        public int AgenciaId { get; set; }

        // Propriedades de navegação
        // Utilizamos dessa maneira em relaçõoes MUITOS PARA UM
        public virtual Cliente Cliente { get; set; }  // Navegação para a entidade Cliente
        public virtual Agencia Agencia { get; set; }  // Navegação para a entidade Agencia
    }
