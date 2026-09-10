using Microsoft.Extensions.Configuration;
using RandomCatFactsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RandomCatFactsApp.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl;

        public ApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl")!;
        }

        public async Task<RandomFact> GetRandomFactAsync()
        {
           var response = await _httpClient.GetAsync(_baseUrl);
           response.EnsureSuccessStatusCode();

           
            var stringResponse= await response.Content.ReadAsStringAsync();

            RandomFact? randomFact;

            try
            {
               randomFact = JsonSerializer.Deserialize<RandomFact>(stringResponse, 
                   new JsonSerializerOptions
               {
                   PropertyNameCaseInsensitive = true
               });
            }
            catch(JsonException ex)
            {
                throw new InvalidOperationException("Api returned invalid JSON.", ex);
            }

            if (randomFact==null)
            { 
                throw new InvalidOperationException("API returned an unexpected null value."); 
            }
           

            return randomFact;
        }
    }
}

