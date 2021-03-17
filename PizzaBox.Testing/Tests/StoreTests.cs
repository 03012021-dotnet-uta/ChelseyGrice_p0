using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class StoreTests
  {
    [Fact]
    public void Test_ChicagoStore_Fact()
    {
      // arrange
      var sut = new ChicagoStore(){
        Name = "Chicago Store"
      };
      var expected = "Chicago Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Chicago Store")]
    public void Test_ChicagoStore_Theory(string expected)
    {
      // arrange
      var sut = new ChicagoStore(){
        Name = "Chicago Store"
      };

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }


    //test for NY store
    [Fact]
    public void Test_NewYorkStore_Fact()
    {
      // arrange
      var sut = new NewYorkStore(){
        Name = "NewYork Store"
      };
      var expected = "NewYork Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
  }
}