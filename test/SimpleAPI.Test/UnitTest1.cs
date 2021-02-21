using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    
    public class UnitTest1
    {
        
        [Fact]
        public void GetWeatherList()
        {
            WeatherForecastController wfc = new WeatherForecastController(null); 

            var retValue = wfc.Get();

            Assert.Equal("Test","Test");
        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}
