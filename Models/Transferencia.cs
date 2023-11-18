using System.ComponentModel.DataAnnotations;
namespace Proejto_Banco.Models;

public class Transferencia{

    [Key]
    public int? id { get; set; }

    public double? Valor { get; set; }
    public string? DataTransferencia { get; set; }

}