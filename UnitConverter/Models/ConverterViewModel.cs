namespace UnitConverter.Models;

public class ConverterViewModel
{
    public double ToConvert { get; set; } /*= 0;*/
    public string? FromUnit { get; set; }
    public string? ToUnit { get; set; }
    public string? ConvertionType { get; set; }
}