using System;

delegate void ConvertTemperature(double celsius);

class TemperatureConverter
{
    static void ToFahrenheit(double c)
    {
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"{c}°C = {f}°F");
    }

    static void ToKelvin(double c)
    {
        double k = c + 273.15;
        Console.WriteLine($"{c}°C = {k}K");
    }

    static void Main()
    {
        ConvertTemperature convert = ToFahrenheit;
        convert += ToKelvin;

        convert(25);
    }
}
