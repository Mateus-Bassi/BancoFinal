using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BancoAPI.Models;
    public enum TipoInvestimento
    {
        CDB,
        TesouroDireto,
        FundoImobiliario
    }
    public class Investimento
    {
        [Key]
        public int Id { get; set; }

        public TipoInvestimento Tipo {get; set;}
        public float ValorInicial {get; set;}
        public DateTime DataInvestimento {get; set;}
        public float RentabilidadeMensal {get; set;}
        public DateTime DataResgate {get; set;}
        public double Taxa {get; set;}

        public int ContaID {get; set;}

        public virtual Conta Conta {get; set;}

    }

