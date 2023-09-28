namespace Example.Shared.Application
{
    internal static class TemperatureConverter
    {
        public static double ToFahrenheit(this float value) => 32 + (value / 0.5556);
    }
}
