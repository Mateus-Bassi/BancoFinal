using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BancoAPI.Models
{
    public enum TipoSeguro
    {
        Vida,
        Residencial,
        Veiculo
    }

    public class Seguro
    {
        // Chave primária
        [Key]
        public int Id { get; set; }
    
        public TipoSeguro Tipo { get; set; }
        public decimal ValorCoberto { get; set; }
        public decimal Premio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        // Chave Estrangeira
        public virtual int ClienteId { get; set; }

        // Propriedade de navegação para Cliente
        public virtual Cliente Cliente { get; set; } // Navegação para a entidade Cliente
    }
}