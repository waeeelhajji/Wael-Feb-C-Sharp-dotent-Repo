using Microsoft.AspNetCore.Mvc;  //? this is service that brings in our MVC functionality
namespace FirstWeb.Controllers;  //? be sure to use your own project's namespace

public class HelloController  : Controller //! remember inheritance 
{
    // Routing!!
    [HttpGet]
    // this goes to localhost:5XXX/
    [Route("")]
    public ViewResult Index()
    {
        //? ViewBag allows us to pass data from our controller to our view
        //? think of viewBag as a Dictionary it has keys and values 
        ViewBag.Name = "Wael";
        ViewBag.Number = 7;
        return View();
    }


    [HttpGet("user/more")]
    public string AUser()
    {
        return "more Information about User!";
    }

    [HttpGet("user/{id}")]
    public string oneUser(int id)
    {
        return $"this is user number {id}";
    }


}   

