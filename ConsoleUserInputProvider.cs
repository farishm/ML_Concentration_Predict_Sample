using System;
using System.Globalization;

public class ConsoleUserInputProvider : IUserInputProvider
{
    public float GetPressure()
    {
        Console.Write("Enter Pressure: ");
        float pressure;
        while (!float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out pressure))
        {
            Console.Write("Invalid input. Enter numeric Pressure: ");
        }

        return pressure;
    }

    public float GetTemperature()
    {
        Console.Write("Enter Temperature: ");
        float temperature;
        while (!float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out temperature))
        {
            Console.Write("Invalid input. Enter numeric Temperature: ");
        }

        return temperature;
    }
}
