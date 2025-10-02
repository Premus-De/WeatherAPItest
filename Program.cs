using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Weather
{
    static async Task Main()
    {
        string apiKey = "07c87c64ab096a5fd8b009ec89f0ed47";
        
        Console.WriteLine(" Weather API Test ");
        Console.Write("Enter city: ");
        string? city = Console.ReadLine();
        
        if (string.IsNullOrEmpty(city))
        {
            Console.WriteLine("Please enter a valid city name.");
            return;
        }
        
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
        
        using (HttpClient client = new HttpClient())
        {
            try
            {
                Console.WriteLine("\nFetching weather data...\n");
                
                string result = await client.GetStringAsync(url);
                
                
                using JsonDocument doc = JsonDocument.Parse(result);
                JsonElement root = doc.RootElement;
                
                
                string? cityName = root.GetProperty("name").GetString();
                string? country = root.GetProperty("sys").GetProperty("country").GetString();
                double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                double feelsLike = root.GetProperty("main").GetProperty("feels_like").GetDouble();
                string? description = root.GetProperty("weather")[0].GetProperty("description").GetString();
                int humidity = root.GetProperty("main").GetProperty("humidity").GetInt32();
                double windSpeed = root.GetProperty("wind").GetProperty("speed").GetDouble();
                
                
                Console.WriteLine($"  Weather in {cityName}, {country}");
                Console.WriteLine($"  Temperature: {temp}°C");
                Console.WriteLine($" Feels Like: {feelsLike}°C");
                Console.WriteLine($" Conditions: {description}");
                Console.WriteLine($" Humidity: {humidity}%");
                Console.WriteLine($" Wind Speed: {windSpeed} m/s");
                Console.WriteLine("\n API Test Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }
    }
}