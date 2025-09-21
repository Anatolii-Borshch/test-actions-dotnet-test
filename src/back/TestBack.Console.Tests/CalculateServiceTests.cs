using TestBack.Console.Services;

namespace TestBack.Console.Tests;

public class CalculateServiceTests
{
    [Fact]
    public void Factorial_Returns_WhenValid()
    {
        //Arrange 
        var service = new CalculateService();
        int result;

        //Act
        result = service.Factorial(4);
        
        //Assert
        Assert.Equal(24, result);
    }

    [Fact]
    public void Factorial_Throws_WhenInvalid()
    {
        //Arrange 
        var service = new CalculateService();
        
        //Assert
        Assert.Throws<ArgumentException>(() => service.Factorial(-1));
    }

    [Fact]
    public void ArraySum_Returns_WhenValid()
    {
        //Arrange 
        var service = new CalculateService();
        int result;

        //Act
        result = service.ArraySum([1,2,3]);
        
        //Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void ArraySum_Throws_WhenInvalid()
    {
        //Arrange
        var service = new CalculateService();
        
        //Assert
        Assert.Throws<ArgumentException>(() => service.ArraySum([]));
    }

    [Fact]
    public void IsPalindrome_Returns_WhenValid()
    {
        //Arrange 
        var service = new CalculateService();

        //Act
        bool result = service.IsPatronimic("abccba");
        
        //Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsPalindrome_Returns_WhenInvalid()
    {
        //Arrange 
        var service = new CalculateService();

        //Act
        bool result = service.IsPatronimic("abccccccc");
        
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_Throws_WhenInvalid()
    {
        //Arrange 
        var service = new CalculateService();
        
        //Assert
        Assert.Throws<ArgumentException>(() => service.IsPatronimic(""));
    }
}
