namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitTemp = 102;
            Console.WriteLine($"{fahrenheitTemp}°F is equal to {TempConverter.FahrenheitToCelsius(fahrenheitTemp)}°C.");

            double celsiusTemp = 36;
            Console.WriteLine($"{celsiusTemp}°C is equal to {TempConverter.CelsiusToFahrenheit(celsiusTemp)}°F.");
        }
    }
}
