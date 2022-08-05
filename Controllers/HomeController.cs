using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyCSharpWithValidations.Models;

namespace DojoSurveyCSharpWithValidations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // specifiying the type of request and the route
    [HttpGet("")]
    // ViewResult is the type of return
    public ViewResult Index()
    {
        // View is a function in the MVC library
        return View("Index");
    }

    // specifiying the type of request and the route
    [HttpPost("results")]
    // ViewResult is the type of return
    public IActionResult Display(Form formSubmission)
    {
        if(ModelState.IsValid)
        {
            // View is a function in the MVC library
            return RedirectToAction("Results");
        }
        else
        {
            return View("Index");
        }
    }
    public IActionResult Results(Form formSubmission)
    {
            return View("Display");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
