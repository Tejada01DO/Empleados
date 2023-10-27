using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Empleados
{
    [Key]
    public int EmpleadoId { get; set; }
    public string? Nombre { get; set; } = string.Empty;
    public string? Apellido { get; set; } = string.Empty;
    public string? Cedula { get; set; } = string.Empty;
    public string? Direccion { get; set; } = string.Empty;
    public string? Telefono { get; set; } = string.Empty;
    public int ProfesionId { get; set; }
    public int DepartamentoId { get; set; }
    public int PuestoId { get; set; }
    public decimal AFP { get; set; }
    public decimal SeguroMedico { get; set; }
    public decimal Impuesto { get; set; }
    public decimal SalarioBase { get; set; }
    public int HorasTrabajadas { get; set; }
    public int HorasExtras { get; set; }
    public int DescuentoPrestamo { get; set; }
    public decimal SalarioNeto { get; set; } 
}