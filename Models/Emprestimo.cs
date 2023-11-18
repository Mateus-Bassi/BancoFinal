using System.ComponentModel.DataAnnotations;
namespace Proejto_Banco.Models;

public class Emprestimo{

    [Key]
    public int? id { get; set; }
    public double? tx_juros{get;} // taxa de juros
    public double? Valor_soli{ get; set; } // valor solicitaod
    public string? Data_soli{ get; set; } // data da solicitacao
    public int? n_parcelas{ get; set; }// numero de parcela

    public double? valor_pagar{ get; set; }// numero de parcela

}