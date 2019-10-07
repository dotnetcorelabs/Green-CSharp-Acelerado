using Marvel.Domain.Models;
using Marvel.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marvel.WPFApp.Repositorios
{
    public class MarvelHttpService : IPersonagemRepositorio
    {
        private readonly HttpClient client;
        private readonly ILogger<MarvelHttpService> logger;

        public MarvelHttpService(HttpClient client, ILogger<MarvelHttpService> logger)
        {
            this.client = client;
            this.client.BaseAddress = new Uri("https://rmauro-marvel-api.herokuapp.com/");

            this.logger = logger;
        }

        public async Task<IReadOnlyList<Personagem>> GetCharacters(string searchString = null, int limit = 10, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("Getting characters with SearchString {SEARCH_STRING} and limit {LIMIT}", searchString, limit);

            string path = searchString == null ? "/api/characters" : $"/api/characters?searchString={searchString}";
            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, path))
            {
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var responseStream = await client.SendAsync(request, cancellationToken);

                    if (responseStream.IsSuccessStatusCode)
                    {
                        var responseText = await responseStream.Content.ReadAsStringAsync();
                        var response = JsonConvert.DeserializeObject<List<Personagem>>(responseText);

                        return response;
                    }
                    logger.LogWarning("Status code response different from success. status code {STATUS_CODE}", responseStream.StatusCode);
                    return Array.Empty<Personagem>();
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error when trying to get Marvel Characters from api with SearchString {SEARCH_STRING} and limit {LIMIT}", searchString, limit);
                    return Array.Empty<Personagem>();
                }
            }
        }
    }
}
