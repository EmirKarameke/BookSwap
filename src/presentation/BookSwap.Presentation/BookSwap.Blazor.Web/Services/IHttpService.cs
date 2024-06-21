using System.Text.Json;

namespace BookSwap.Blazor.Web.Services
{
    public interface IHttpService
    {
        Task<object>GetObjectAsync(ServiceRequestBase request);
        Task<string> PostAsync(ServiceRequestBase request);
    }

    public class HttpService : IHttpService
    {
        HttpClient client;

        public HttpService(HttpClient client)
        {
            this.client = client;
        }

        public Task<object> GetObjectAsync(ServiceRequestBase request)
        {
            client.GetAsync(request.Url);

            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ServiceRequestBase request)
        {
            try
            {
                var response = await client.PostAsync(request.Url, request.Object);
                var responseContent = await response.Content.ReadAsStringAsync();
                //var result = JsonSerializer.Deserialize<string>(responseContent);
                return responseContent;
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
