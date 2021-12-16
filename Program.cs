using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelciusToFahrenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"Celcius: {celcius}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}
