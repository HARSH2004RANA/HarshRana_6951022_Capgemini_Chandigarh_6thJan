using CalculatorApp;
namespace TestProjectCal.Tests;

public class CalculatorTest
{
    private Calculator cal;
    [SetUp]
    public void Setup()
    {
        cal = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        //Arrange
        int a = 5, b = 3;

        //Act
        int result=cal.Add(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsSum()
    {
        //Arrange
        int a = 5, b = 3;

        //Act
        int result = cal.Subtract(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiple_TwoNumbers_ReturnsSum()
    {
        //Arrange
        int a = 5, b = 3;

        //Act
        int result = cal.Multiply(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(15));
    }
}
