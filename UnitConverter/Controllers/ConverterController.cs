using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
namespace UnitConverter.Controllers;

public class ConverterController : Controller
{
    private readonly ILogger<ConverterController> _logger;

    public ConverterController(ILogger<ConverterController> logger)
    {
        _logger = logger;
    }
    public IActionResult LenghtConverter()
    {
        return View();
    }
    public IActionResult WeightConverter()
    {
        return View();
    }
    public IActionResult TemperatureConverter()
    {
        return View();
    }

    public IActionResult ConversionResult(ConverterViewModel converterVM)
    {
        switch (converterVM.ConvertionType)
        {
            case "lenght":
                break;
            case "temperature":
                break;
            case "weight":
                break;
        }

        // créer la nouvelle page
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
