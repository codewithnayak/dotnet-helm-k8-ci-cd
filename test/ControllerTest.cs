namespace test;
using Xunit;
using src.Controllers;

public class ControllerTest
{
    [Fact]
    public void Test1()
    {
        var controller = new WeatherForecastController(null);
        var result = controller.GetValue();
        Assert.NotNull(result);

    }
}