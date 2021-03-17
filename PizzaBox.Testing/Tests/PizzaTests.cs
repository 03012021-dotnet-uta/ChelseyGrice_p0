using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    [Fact]
    public void Test_CustomePizza_Fact()
    {
      // arrange
      var sut = new CustomPizza(){
          Name = "Custom Pizza"
      };
      var expected = "Custom Pizza";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Custom Pizza")]
    public void Test_CustomPizza_Theory(string expected)
    {
      // arrange
      var sut = new CustomPizza(){
          Name = "Custom Pizza"
      };

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_PepperoniPizza_Fact()
    {
      // arrange
      var sut = new PepperoniPizza(){
          Name = "Pepperoni Pizza"
      };
      var expected = "Pepperoni Pizza";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_VeggiePizza_Fact()
    {
      // arrange
      var sut = new VeggiePizza(){
          Name = "Veggie Pizza"
      };
      var expected = "Veggie Pizza";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test_CheesePizza_Fact()
    {
      // arrange
      var sut = new CheesePizza(){
          Name = "Cheese Pizza"
      };
      var expected = "Cheese Pizza";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
  }
}