using Whoami.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;

namespace HostApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Produces("application/json")]
    public WhoamiResponse Get()
    {
        var feature = HttpContext.Features.Get<IHttpConnectionFeature>();
	    var localIpAddress = feature?.LocalIpAddress == null ? "xx.xx.xx.xx <no IP address>" : feature.LocalIpAddress.ToString();
        
        Console.WriteLine($"Local IP address: {localIpAddress}");
        Console.WriteLine($"Request scheme: {HttpContext.Request.Scheme}");
        Console.WriteLine($"Request host: {HttpContext.Request.Host}");
        Console.WriteLine($"Request path: {HttpContext.Request.Path}");
        Console.WriteLine($"Request method: {HttpContext.Request.Method}");
        Console.WriteLine($"Request content type: {HttpContext.Request.ContentType}");
        Console.WriteLine($"Request content length: {HttpContext.Request.ContentLength}");
        Console.WriteLine($"Request body: {HttpContext.Request.Body}");
        Console.WriteLine($"Request headers: {HttpContext.Request.Headers.Select(x => $"{x.Key}: {x.Value}")}");
        Console.WriteLine($"Request cookies: {HttpContext.Request.Cookies}");
        Console.WriteLine($"Request query: {HttpContext.Request.Query}");

        return new WhoamiResponse(localIpAddress, Request.Scheme);
    }
}
