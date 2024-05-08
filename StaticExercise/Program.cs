namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(86);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(30);

            Console.WriteLine($"If the tempeture in USA is {fahrenheit} then in England it would be {celsius}");
        }
    }
}
