using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Profesiones
{
    [Key]
    public int ProfesionId { get; set; }
    public string? Nombre { get; set; }
}

public class Departamentos
{
    [Key]
    public int DepartamentoId { get; set; }
    public int ProfesionId { get; set; }
    public string? Nombre { get; set; }
}

public class Puestos
{
    [Key]
    public int PuestoId { get; set; }
    public int DepartamentoId { get; set; }
    public string? Nombre { get; set; }
}
