namespace UnitConverter.Models;

public class ResultViewModel(ConverterViewModel converterViewModel, double? convertedUnit)
{
    public ConverterViewModel ConverterViewModel { get; set; } = converterViewModel;
    public double? ConvertedUnit { get; set; } = convertedUnit;
}