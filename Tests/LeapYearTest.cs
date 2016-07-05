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

    }
  }
}
