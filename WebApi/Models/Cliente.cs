using WebApi.Models.Base;

namespace WebApi.Models;

public class Cliente: Model
{
    public string? Name {get; set;}

    public string? LastName {get; set;}

    public int? celular {get; set;}

    public int? direccion {get; set;}

    public string? ClienteId {get; set;}
    
    
}