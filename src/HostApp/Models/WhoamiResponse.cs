namespace Whoami.Models;

public class WhoamiResponse
{
    public string Now { get; }
    public string? IpAddress { get; set; }
    public string? Scheme { get; set; }
    public string? Host { get; set; }
    public string? Path { get; set; }
    public string? Method { get; set; }
    public string? ContentType { get; set; }
    public long? ContentLength { get; set; }
    public Dictionary<string, string> Headers { get; set; }
    public Dictionary<string, string> Cookies { get; set; }

    public WhoamiResponse()
    {
        Now = DateTime.Now.ToString();
        Headers = new Dictionary<string, string>();
        Cookies = new Dictionary<string, string>();
    }
}
