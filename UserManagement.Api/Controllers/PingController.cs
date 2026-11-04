using Microsoft.AspNetCore.Mvc; //library class for Controller and Attributes
namespace UserManagement.Api.Controllers; //prject name (.Api.) then the file

[ApiController] //API attribute to make this class a controller like 400 
[Route("api/[controller]")] //sets the route for this controller, [controller] is a placeholder for the controller name (Ping)
public class PingController : ControllerBase //: to inherit from ControllerBase class which provides methods and properties for handling HTTP requests and responses
{
    [HttpGet] //this function only takes GET requests, if you try to send a POST request to this endpoint it will return 405 Method Not Allowed
    public IActionResult Get() //IActionResult is an interface that defines a contract for the result of an action method. It allows you to return different types of responses, such as Ok, NotFound, BadRequest, etc.
    {
        return Ok("pong");//returns a 200 OK response with the string "pong" in the response body
    }



}

             