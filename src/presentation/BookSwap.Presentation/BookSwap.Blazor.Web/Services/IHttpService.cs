using BookSwap.Application.Contract.ServiceTypes;
using Newtonsoft.Json;
using System.Text.Json;

namespace BookSwap.Blazor.Web.Services
{
    public interface IHttpService
    {
        Task<object>GetObjectAsync(ServiceRequestBase request);
        Task<ServiceResponse<T>> PostAsync<T>(ServiceRequestBase request);
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

        public async Task<ServiceResponse<T>> PostAsync<T>(ServiceRequestBase request)
        {
            try
            {
                var response = await client.PostAsync(request.Url, request.Object);
                var responseContent = await response.Content.ReadAsStringAsync();
                
                var result = JsonConvert.DeserializeObject<ServiceResponse<T>>(responseContent);
                return result;
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}
