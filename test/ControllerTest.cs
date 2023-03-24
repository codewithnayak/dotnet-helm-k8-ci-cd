namespace test;
using Xunit;
using src.Controllers;
using Microsoft.Extensions.Logging;

public class ControllerTest
{
    [Fact]
    public void Test1()
    {
        var controller = new WeatherForecastController(default(ILogger<WeatherForecastController>));
        var result = controller.GetValue();
        Assert.NotNull(result);

    }
}