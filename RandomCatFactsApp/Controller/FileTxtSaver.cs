using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Http;
using RandomCatFactsApp.Models;
using RandomCatFactsApp.Services;

namespace RandomCatFactsApp.Controller
{
    internal class FileTxtSaver
    {
        private readonly IConfiguration _configuration;
        private readonly IApiService _apiService;
        private readonly string _filePath;
        private readonly int _numberOfRequests;

        public FileTxtSaver(IConfiguration configuration, IApiService apiService)
        {
            _configuration = configuration;
            _apiService = apiService;
            _filePath = _configuration.GetValue<string>("FileSettings:FilePath")!;
            _numberOfRequests = _configuration.GetValue<int>("FileSettings:NumberOfRequests"); 
        }


        public async Task SaveToFileAsync()
        {
            

            for ( int i=0; i < _numberOfRequests; i++)
            {
                var randomFact = await _apiService.GetRandomFactAsync();
               await File.AppendAllTextAsync(_filePath, randomFact.Fact + ";" + randomFact.Length + Environment.NewLine);
            }
            
        }
       
    }
}
