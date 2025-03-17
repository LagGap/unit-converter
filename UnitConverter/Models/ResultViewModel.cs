namespace UnitConverter.Models;

public class ResultViewModel(ConverterViewModel converterViewModel, double? convertedUnit)
{
    public ConverterViewModel converterViewModel { get; set; } = converterViewModel;
    public double? convertedUnit { get; set; } = convertedUnit;


}