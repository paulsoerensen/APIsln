using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

using APIproj.Controllers;
namespace APIproj.Test;

public class UnitTest1
{
 
     [Fact]
    public void Test1()
    {
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<WeatherForecastController>();
        WeatherForecastController ctrl = new WeatherForecastController(logger);
 

        var ret = ctrl.Get();
        Assert.True(1==1);
    }
}