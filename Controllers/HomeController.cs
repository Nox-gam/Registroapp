using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Registroapp.Models;

namespace Registroapp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CalcularCurso(RegistroModel registro)
    {
        //string mensaje = string.Empty;
        double igv = 0.0;
        double total = 0.0;
        double totalPagar = 0.0;
        int i = 0;

        if (registro.Matematica)
            i = i + 1;
        if (registro.Lenguaje)
            i = i+1;
        if (registro.Historia)
            i = i+1;

        total = i * (i * 100);
        igv = total * 0.18;
        totalPagar = total + igv;
        //&nbsp

        ViewData["Message1"] = "TOTAL CURSOS: " + total.ToString();
        ViewData["Message2"] = "IGV: " + igv.ToString();
        ViewData["Message3"] = "Total a pagar: " + totalPagar.ToString();
        
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
