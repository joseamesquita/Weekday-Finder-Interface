namespace WeekdayFinder.Models
{
  public class WeekdayFinder
  {
    public int Result { get; set; }

    public int Result2 { get; set; }

    public int Result3 { get; set; }

    public WeekdayFinder(int result, int result2, int result3)
    {
      Result = result;
      Result2 = result2;
      Result3 = result3;
    }

  }
}