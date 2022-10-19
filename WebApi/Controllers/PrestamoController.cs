using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class prestamo: ApiControllerBase<Prestamo>
{
    public prestamo(DataContext context, ILogger<Prestamo> logger) : base (context, logger){
        
    }
}