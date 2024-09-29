using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc2.Data;
using pc2.Models;

namespace pc2.Controllers;

public class ClienteController : Controller
{
    private readonly ILogger<ClienteController> _logger;
    private readonly ApplicationDbContext _context;

    public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Form(){
        return View();
    }

    public IActionResult List(){
        var clienteLista = _context.DataCliente.ToList();
        return View(clienteLista);
    }

    [HttpPost] //MÉTODO POST
    public IActionResult Enviar(Cliente objcliente){
        _logger.LogDebug("Ingreso a Enviar Mensaje");
        _context.Add(objcliente);
        _context.SaveChanges();

        ViewData["Message"] = "Se registró el contacto con éxito :D";

        return View("Form");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
