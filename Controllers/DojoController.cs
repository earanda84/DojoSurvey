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

    // Posterior se debe llamar a la ruta result, con metodo get para el renderizado de la ruta
    [HttpGet]
    [Route("result")]
    public ViewResult Result()
    {
        return View("result");
    }
    // se llama mediante post se envian los datos del formulario a la ruta post del backend
    [HttpPost("result")]
    public IActionResult Result(string Name, string Location, string Language, string Comment)
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Language: {Language}");
        Console.WriteLine($"Comment: {Comment}");

        TempData["Name"] = Name;
        TempData["Location"] = Location;
        TempData["Language"] = Language;
        TempData["Comment"] = Comment;

        return RedirectToAction("Result");
    }


}