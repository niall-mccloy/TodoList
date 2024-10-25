using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TodoAppMvc.Controllers;

public class TodoAppController : Controller
{
        // 
    // GET: /TodoApp/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /TodoApp/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}