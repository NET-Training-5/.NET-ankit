using Microsoft.AspNetCore.Mvc;
public class MultipleController: Controller
{
    public IActionResult Output() //      /multiple/output
    {
        return View();
    }
}