using System;
using Microsoft.AspNetCore.Mvc;
namespace Time_Display
{
  public class TimeController : Controller
  {
    [HttpGet("")]
    public ViewResult TimeDisplay()
    {
      DateTime CurrentTime = DateTime.Now;
      string format = "ddd, MMM d, yyyy HH:mm tt";
      Console.WriteLine(CurrentTime.ToString(format));
      ViewBag.Date = CurrentTime.ToString(format);
      return View("TimeDisplay");
    }
  }
}