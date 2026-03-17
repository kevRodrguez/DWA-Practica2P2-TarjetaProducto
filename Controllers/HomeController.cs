using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica2P2_KevinRodriguez.Models;

namespace Practica2P2_KevinRodriguez.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var producto = new TarjetaProductoViewModel
        {
            NombreProducto = "Laptop HP Pavilion",
            Precio = "$899.99",
            Descripcion = "Equipo ideal para clases, desarrollo web y tareas universitarias."
        };

        return View(producto);
    }

    public IActionResult Privacy()
    {
        var producto = new TarjetaProductoViewModel
        {
            NombreProducto = "Mouse Inalambrico Logitech",
            Precio = "$24.99",
            Descripcion = "Accesorio comodo y practico para acompanar tu espacio de estudio."
        };

        return View(producto);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
