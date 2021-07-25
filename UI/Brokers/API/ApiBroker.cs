using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Json;
using UI.Brokers.Logging;

namespace UI.Brokers.API
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly HttpClient httpClient;
        private readonly ILoggingBroker logger;
        public ApiBroker(HttpClient httpClient, ILoggingBroker loggingBroker)
        {
            this.httpClient = httpClient;
            this.logger = loggingBroker;
        }

        private async ValueTask<T> GetAsync<T>(string releativeUrl)
        {
            logger.Information($"GetAsync {typeof(T)} | {releativeUrl}");
            return await httpClient.GetFromJsonAsync<T>(releativeUrl);
        }

        private async ValueTask<T> PostAsync<T>(string releativeUrl, T content)
        {
            logger.Information($"PostAsync {typeof(T)} | {releativeUrl}");
            var response = await httpClient.PostAsJsonAsync<T>(releativeUrl, content);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

        private async ValueTask<T> PutAsync<T>(string releativeUrl, T content)
        {
            logger.Information($"PutAsync {typeof(T)} | {releativeUrl}");
            var response = await httpClient.PutAsJsonAsync<T>(releativeUrl, content);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

        private async ValueTask<T> DeleteAsync<T>(string releativeUrl, T content)
        {
            logger.Information($"DeleteAsync {typeof(T)} | {releativeUrl}");
            var response = await httpClient.DeleteAsync(releativeUrl);
            return response.Content.ReadFromJsonAsync<T>().Result;
        }

    }
}
