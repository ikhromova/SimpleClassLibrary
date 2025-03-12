using Xunit;

namespace SimpleClassLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var instance = new Class1();

        // Act
        var result = instance.ToString();

        // Assert
        Assert.False(result == "Hello World!");

    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var instance = new Class1();

        // Act
        var result = instance.Add(2,3);

        // Assert
        Assert.True(result == 5);

    }
}
