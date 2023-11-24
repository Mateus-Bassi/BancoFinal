
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BancoAPI.Models;

    public class CartaoCredito
    {   
        [Key]
        public int? Id {get; set;}

        public string? NumeroCartao {get; set;}
        public DateTime? DataValidade {get; set;}
        public string? CodigoSeguranca {get; set;}
        public decimal? Limite {get; set;}
        public bool? Bloqueado {get; set;}

        public int ContaID {get; set;}
        
        public Conta Conta {get; set;}       
    }
