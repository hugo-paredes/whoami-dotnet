using Whoami.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;

namespace HostApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Produces("application/json")]
    public WhoamiResponse Get()
    {
        var headers = new Dictionary<string, string>();
        var cookies = new Dictionary<string, string>();
        var feature = HttpContext.Features.Get<IHttpConnectionFeature>();
	    var localIpAddress = feature?.LocalIpAddress == null
            ? "xx.xx.xx.xx <no IP address>"
            : feature.LocalIpAddress.ToString();

        foreach (var header in HttpContext.Request.Headers)
        {
            headers.Add(header.Key, header.Value);
        }
        foreach (var cookie in HttpContext.Request.Cookies)
        {
            cookies.Add(cookie.Key, cookie.Value);
        }

        return new WhoamiResponse
        {
            IpAddress = localIpAddress,
            Scheme = HttpContext.Request.Scheme,
            Host = HttpContext.Request.Host.ToString(),
            Path = HttpContext.Request.Path,
            Method = HttpContext.Request.Method,
            ContentType = HttpContext.Request.ContentType,
            ContentLength = HttpContext.Request.ContentLength,
            Headers = headers,
            Cookies = cookies
        };
    }
}
