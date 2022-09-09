using FluentAssertions;
using NUnit.Framework;
using Encapsulation.Models;

    
namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {
        private WeatherReporter _myWeatherReporter;
        private const string Expected_Output_Location_California_Temperature_29 = "I am in California and it is 🌅. " +
                                               "Ahhh...it's just right 😊!. The temperature in Fahrenheit is 84.2.";
        private const string Expected_Output_Location_London_Temperature_9 = "I am in London and it is 🌦. " +
                                                "It's too cold 🥶!. The temperature in Fahrenheit is 48.2.";
        private const string Expected_Output_Location_CapeTown_Temperature_35 = "I am in Cape Town and it is 🌤. " +
                                                "It's too hot 🥵!. The temperature in Fahrenheit is 95.";
        private const string Expected_Output_Location_OtherLocation_Temperature_1 = "I am in India and it is 🔆. " +
                                                "It's too cold 🥶!. The temperature in Fahrenheit is 33.8.";
        private const string Expected_Output_Location_EmptyNull_Temperature_1 = "Location can't be null";


        [SetUp]
        public void Setup()
        {
             _myWeatherReporter = new WeatherReporter();
        }

        [Test]
        public void Location_California_Temperature_29()
        {
            _myWeatherReporter.GetWeatherReport("California", 29).Should().Be(Expected_Output_Location_California_Temperature_29);
        }

        [Test]
        public void Location_London_Temperature_9()
        {
            _myWeatherReporter.GetWeatherReport("London", 9).Should().Be(Expected_Output_Location_London_Temperature_9);
        }

        [Test]
        public void Location_Cape_Town_Temperature_35()
        {
            _myWeatherReporter.GetWeatherReport("Cape Town", 35).Should().Be(Expected_Output_Location_CapeTown_Temperature_35);
        }

        [Test]
        public void Location_OtherLocation_Temperature_1()
        {
            _myWeatherReporter.GetWeatherReport("India", 1).Should().Be(Expected_Output_Location_OtherLocation_Temperature_1);
        }

        [Test]
        public void Location_Empty_Temperature_1_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => _myWeatherReporter.GetWeatherReport("", 1));
            Assert.That(ex.Message, Is.EqualTo(Expected_Output_Location_EmptyNull_Temperature_1));
        }

        [Test]
        public void Location_null_Temperature_1_Exception()
        {
            var ex = Assert.Throws<ArgumentException>(() => _myWeatherReporter.GetWeatherReport(null, 1));
            Assert.That(ex.Message, Is.EqualTo(Expected_Output_Location_EmptyNull_Temperature_1));
        }

    }
}