using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class editorial: ApiControllerBase<Editorial>
{
    public editorial(DataContext context, ILogger<Editorial> logger) : base (context, logger){
        
    }
}