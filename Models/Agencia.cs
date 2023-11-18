// Juan 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BancoAPI.Models
{
    public class Agencia
    {
        // Chave Primária
        [Key]
        public int Id { get; set; }

        public string NumeroAgencia { get; set; }
        public string Nome { get; set; }
        
        // Relacionamento com Endereco
        public int EnderecoId { get; set; }  // Chave estrangeira
        
        public virtual Endereco Endereco { get; set; }  // Propriedade de navegação

    }
}