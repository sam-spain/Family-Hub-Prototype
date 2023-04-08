using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class TasksController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index(string name)
    {
        var view = "There will be a list of tasks here someday!";
        if(name != "") {
            view += "\nThese tasks will be shown for: " + name;
        }
        return HtmlEncoder.Default.Encode(view);
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}