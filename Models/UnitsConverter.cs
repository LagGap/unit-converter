namespace UnitConverter.Models;

public class UnitsConverter
{
    public Dictionary<string, double> lenghtMapping = new Dictionary<string, double>
    {
        {"millimeter",0.001},
        {"centimeter",0.01},
        {"meter",1},
        {"kilometer",1000},
        {"inch", 0.0254},
        {"foot", 0.3048},
        {"yard", 0.9144},
        {"mile", 1609.34}
    };
    public Dictionary<string, double> weightMapping = new Dictionary<string, double>
    {
        {"milligram", 0.001},
        {"gram", 1},
        {"kilogram", 1000},
        {"ounce", 28.3495},
        {"pound", 453.592}
    };

    public double ConvertLenght(double inputValue, string fromUnit, string toUnit)
    {
        double fromUnitValue = lenghtMapping[fromUnit] * inputValue;
        return fromUnitValue / lenghtMapping[toUnit];
    }
    public double ConvertWeight(double inputValue, string fromUnit, string toUnit)
    {
        double fromUnitValue = weightMapping[fromUnit] * inputValue;
        return fromUnitValue / weightMapping[toUnit];
    }

    public double ConvertTemperature(double inputValue, string fromUnit, string toUnit)
    {
        double convertedInputValue = 0;
        if (fromUnit == toUnit)
        {
            return inputValue;
        }

        //from other to celsius
        switch (fromUnit)
        {
            case "celsius":
                convertedInputValue = inputValue;
                break;
            case "fahrenheit":
                convertedInputValue = (inputValue - 32) * 5 / 9;
                break;
            case "kelvin":
                convertedInputValue = inputValue - 273.15;
                break;
            default:
                return convertedInputValue;
        }

        // from Celsius to willing unit with toUnit
        switch (toUnit)
        {
            case "celsius":
                return convertedInputValue;                
            case "fahrenheit":
                convertedInputValue = convertedInputValue * 9 / 5 + 32 ;
                break;
            case "kelvin":
                convertedInputValue -= 273.15;
                break;
            default:
                return convertedInputValue;
        }

        return convertedInputValue;
    }
}