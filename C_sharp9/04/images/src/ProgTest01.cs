using StanProg;
using Xunit;

nasmepsace CalcLibUnitTest
{
  public class CalcUnitTest
  {
    [Fact]
    public void TestAdd() {
      //arrange
      double a = 2;
      double b = 4;
      double expected = 6;
      var calc new Calculator();

      //act
      double actual = calc.Add(a,b);
      //assert
      Assert.Equal(expected, actual);
    }
    [Fact]
    public void TestAddAnother(){
      //arrange
      double a = 5;
      double b = 5;
      double expected = 10;
      var calc = new Calculator();

      //act
      double actual = calc.Add(a, b);

      //assert
      Assert.Equal(expected, actual);
    }
  }
} //dotnet test
