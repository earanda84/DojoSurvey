using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;

public class DojoController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("result")]
    public ViewResult Result()
    {
        return View("result");
    }

    [HttpPost("result")]
    public RedirectToActionResult Result(string Name, string Location, string Language, string Comment)
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Language: {Language}");
        Console.WriteLine($"Comment: {Comment}");

        // ViewData["Name"] = Name;
        // ViewData["Location"] = Location;
        // ViewData["Language"] = Language;
        // ViewData["Comment"] = Comment;
        TempData["Name"] = Name;
        TempData["Location"] = Location;
        TempData["Language"] = Language;
        TempData["Comment"] = Comment;

        return RedirectToAction("Result");
    }


}