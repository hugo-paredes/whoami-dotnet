namespace Whoami.Models;

public class WhoamiResponse
{
    public string IpAddress { get; set; }
    public string Now { get; set; }
    public string RequestScheme { get; set; }

    public WhoamiResponse(string ipAddress, string scheme)
    {
        Now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        IpAddress = ipAddress;
        RequestScheme = scheme;
    }
}
