// Coloca EndereçoID como chave primaria, ao inves de CEP
using System;
using System.ComponentModel.DataAnnotations;
namespace BancoAPI.Models{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public virtual Agencia Agencia { get; set; }  // Navegação para a entidade Agencia
    }
}
