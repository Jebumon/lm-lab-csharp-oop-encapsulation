using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperatureInCelsius;
        private const double FAHRENHEIT_CONSTANT = (9.0 / 5.0);
        private const int FAHRENHEIT_OFFSET   = 32;
        private const int NORMAL_TEMPERATURE_UPPER_LIMIT  = 30;
        private const int COLD_TEMPERATURE_UPPER_LIMIT    = 10;

        public WeatherReporter()
        {
            _location = "";
            _temperatureInCelsius = 0;
        }

        public string GetWeatherReport(string location, double temperatureInCelsius)
        {
            _location = location;
            _temperatureInCelsius = temperatureInCelsius;
            if (_location != "" && _location != null )
            {
                double TempInFahrenheit = FAHRENHEIT_CONSTANT * _temperatureInCelsius + FAHRENHEIT_OFFSET;
                TempInFahrenheit = (double)Math.Round((Decimal)TempInFahrenheit, 2, MidpointRounding.AwayFromZero);
                return $"I am in {_location} and it is {PickWetherEmoji()}. {PickTemperatureEmoji()}. The temperature in Fahrenheit is {TempInFahrenheit}.";
            }
            throw new ArgumentException(message: "Location can't be null");
        }
        private string PickWetherEmoji()
        {
            switch (_location) 
            {
                case "London":
                    return "🌦";
                    
                case "California":
                    return "🌅";

                case "Cape Town":
                    return "🌤";

                default:
                    return "🔆";

            }

        }

        private string PickTemperatureEmoji()
        {
            switch (_temperatureInCelsius)
            {
                case > NORMAL_TEMPERATURE_UPPER_LIMIT:
                    return "It's too hot 🥵!";

                case < COLD_TEMPERATURE_UPPER_LIMIT:
                    return "It's too cold 🥶!";

                default:
                    return "Ahhh...it's just right 😊!";

            }

        }

    }
}

