using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Json;

namespace UI.Brokers.API
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly HttpClient httpClient;
        public ApiBroker(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private async ValueTask<T> GetAsync<T>(string releativeUrl)
        {
            return await httpClient.GetFromJsonAsync<T>(releativeUrl);
        }

        private async ValueTask<T> PostAsync<T>(string releativeUrl, T content)
        {
            var response = await httpClient.PostAsJsonAsync<T>(releativeUrl, content);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

        private async ValueTask<T> PutAsync<T>(string releativeUrl, T content)
        {
            var response = await httpClient.PutAsJsonAsync<T>(releativeUrl, content);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

        private async ValueTask<T> DeleteAsync<T>(string releativeUrl, T content)
        {
            var response = await httpClient.DeleteAsync(releativeUrl);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

    }
}
