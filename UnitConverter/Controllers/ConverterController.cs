using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
namespace UnitConverter.Controllers;

public class ConverterController : Controller
{
    private readonly ILogger<ConverterController> _logger;
    private readonly UnitsConverter converter;

    public ConverterController(ILogger<ConverterController> logger)
    {
        _logger = logger;
        converter = new();
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
        double? converted = 0;
        switch (converterVM.ConvertionType)
        {
            case "lenght":
                if (converterVM.FromUnit != null && converterVM.ToUnit != null && converterVM.ToConvert != null) // after I check if the strings are not null
                {
                    converted = converter.ConvertLenght(converterVM.ToConvert, converterVM.FromUnit, converterVM.ToUnit);
                }
                break;
            case "temperature":
                break;
            case "weight":
                break;
        }
        
        ResultViewModel result = new ResultViewModel(converterVM, converted);
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
