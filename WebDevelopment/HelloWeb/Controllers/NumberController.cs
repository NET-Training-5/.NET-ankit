
using Microsoft.AspNetCore.Mvc;
public class NumberController : Controller
{
    public IActionResult Table()     // /number/table
    {
        
        return View();
    }
    public IActionResult MultiplicationTable(int from, int to)
    {
        return View((from, to));
    }
}