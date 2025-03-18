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
        double converted = 0;
        if (converterVM.UnitsAreValid())
        {
            switch (converterVM.ConvertionType)
            {
                case "lenght":
                    converted = converter.ConvertLenght(converterVM.ToConvert, converterVM.FromUnit, converterVM.ToUnit);
                    break;
                case "temperature":
                    converted = converter.ConvertTemperature(converterVM.ToConvert, converterVM.FromUnit, converterVM.ToUnit);
                    break;
                case "weight":
                    converted = converter.ConvertWeight(converterVM.ToConvert, converterVM.FromUnit, converterVM.ToUnit);
                    break;
            }
        }

        ResultViewModel result = new(converterVM, converted);
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
