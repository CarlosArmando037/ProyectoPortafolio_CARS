using Microsoft.AspNetCore.Mvc;
using PortafolioCARS.Api.Services;

namespace PortafolioCARS.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MisproyectosController : ControllerBase{
    private readonly ILogger<MisproyectosController> _logger;
    private readonly ProyectoServices _proyectoservices;

    public MisproyectosController(
        ILogger<MisproyectosController> logger,
        ProyectoServices proyectoServices)
    {
        _logger =logger;
        _proyectoservices = proyectoServices; 
    }
    [HttpGet]
    public async Task<IActionResult> GetProyectos(){
        var proyectos = await _proyectoservices.GetAsync();
        return Ok(proyectos);
    }
}