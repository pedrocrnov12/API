using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{
  

    public DateTime FechaPrestamo {get; set;}
    public DateTime FechaRegreso {get; set;}
    public string? ClienteId {get; set;}
    public int? LibroId {get; set;}

  



    
    
}