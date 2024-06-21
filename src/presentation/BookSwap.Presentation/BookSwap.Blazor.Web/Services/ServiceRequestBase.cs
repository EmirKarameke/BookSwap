namespace BookSwap.Blazor.Web.Services
{
    public class ServiceRequestBase
    {
        public string Url { get; set; } = "https://localhost:7238/";
        public HttpContent? Object { get; set; }
    }
}
