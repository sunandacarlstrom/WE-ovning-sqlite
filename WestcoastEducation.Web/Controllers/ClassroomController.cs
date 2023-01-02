using Microsoft.AspNetCore.Mvc;
using WestcoastEducation.Web.Models;

namespace WestcoastEducation.Web.Controllers;

[Route("classroom")]
public class ClassroomController : Controller
{
    public IActionResult Index()
    {
        var classroom = new List<Classroom>{
            new Classroom(1, false) { Name = "Webbapplikation MVP", Content = "Grunderna i HTML, CSS och JavaScript"},
            new Classroom(2, false) { Name = "Objektorienterad programmering med C#", Content = "Grunderna i OOP och C#"},
            new Classroom(3, false) { Name = "Dynamiska Webbsystem 1", Content = "Grunderna i MVC med TDD"}
            };

        return View("Index", classroom);
    }

    [Route("details/{courseId}")]
    public IActionResult Details(int courseId)
    {
        var foundClassroom = new Classroom(12, false)
        {
            Name = "Webbapplikation MVP",
            Content = "Grunderna i HTML, CSS och JavaScript"
        };

        return View("Details", foundClassroom);
    }
}
