using Xunit; //imports Xunit framework to use
namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact] //tells compiler that the following is a test that should be run by Xunit.
    //Below is the test itself. Xunit tests are methods and should always start with public void.
    //The naming convention we are using here is basically: methodWeAreTesting_whatBehaviorWeAreTesting_expectedResultOfTest
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      LeapYear testLeapYear = new LeapYear(); //Creating an instance of our LeapYear class.
      Assert.Equal(true, testLeapYear.IsLeapYear(2012)); //An assertion that tells Xunit to look at the first arguement and the second arguement and check their equality. Assert.Equal(true, 1 == 1) is an example of a passing test, too.
    }
    [Fact]
    public void IsLeapYear_ForNumberNotDivisibleByFour_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1999));
    }
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByOneHundred_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1900));
    }
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
