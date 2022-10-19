using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class clienteController: ApiControllerBase<Cliente>
{
    public clienteController(DataContext context, ILogger<Cliente> logger) : base (context, logger){
        
    }
}