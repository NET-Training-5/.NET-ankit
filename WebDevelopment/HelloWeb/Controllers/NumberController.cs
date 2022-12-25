
using Microsoft.AspNetCore.Mvc;
public class NumberController : Controller
{
    public IActionResult Greet()     // /number/greet
    {
        
        return View();
    }
}