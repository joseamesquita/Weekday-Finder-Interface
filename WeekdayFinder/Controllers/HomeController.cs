using Microsoft.AspNetCore.Mvc;
using WeekdayFinder.Models;

namespace WeekdayFinder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form()
    {

      // Weekday dates = new Weekday(result, result2, result3);
      // dates.Result = result;



      // Console.WriteLine("Input a month with two digits: Ex: 01 = January, 02 = February, etc.");
      // int result = int.Parse(Console.ReadLine());
      // Console.WriteLine("Input a day with two digits: ");
      // int result2 = int.Parse(Console.ReadLine());
      // Console.WriteLine("Input a year with four digits: ");
      // int result3 = int.Parse(Console.ReadLine());
      // DateTime dateValue = new DateTime(W);
      // Console.WriteLine("-------------------");
      // Console.WriteLine(dateValue.ToString("dddddddd"));

      return View();
    }

  }
}