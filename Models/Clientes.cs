using System.ComponentModel.DataAnnotations;
namespace ApiEmpresa.Models;


public class Clientes{
    [Key]
    public Int32 Id_Clientes { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public DateTime? fecha_nacimineto { get; set; }

}