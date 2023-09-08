namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitTemp = TempConverter.FahrenheitToCelsius(70);
            Console.WriteLine(Math.Round(fahrenheitTemp,2));

            double celsiusTemp = TempConverter.CelsiusToFahrenheit(100);
            Console.WriteLine(Math.Round(celsiusTemp,2));
        }
    }
}
