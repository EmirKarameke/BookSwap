namespace BookSwap.Blazor.Web.Services
{
    public class ServiceRequestBase
    {
        public string Url { get; set; }
        public HttpContent? Object { get; set; }
    }
}
