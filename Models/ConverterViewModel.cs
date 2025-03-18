using System.Reflection.Metadata.Ecma335;

namespace UnitConverter.Models;

public class ConverterViewModel
{
    public double ToConvert { get; set; }
    public required string FromUnit { get; set; }
    public required string ToUnit { get; set; }
    public required string ConvertionType { get; set; }

    public bool UnitsAreValid()
    {
        if (FromUnit != null && ToUnit != null)
        {
            return true;
        }
        return false;
    }
}