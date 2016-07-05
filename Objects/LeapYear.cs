namespace LeapYear
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      if (year % 100 == 0)
      {
        return false;
      }
      else if (year % 400 == 0)
      {
        return true;
      }
      else
      {
        return year % 4 == 0;
      }
    }
  }
}
