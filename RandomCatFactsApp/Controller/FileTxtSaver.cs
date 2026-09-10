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

        public FileTxtSaver(IConfiguration configuration, IApiService apiService)
        {
            _configuration = configuration;
            _apiService = apiService;
            _filePath = _configuration.GetValue<string>("FileSettings:FilePath")!;
        }


        public async Task<RandomFact> SaveToFileAsync()
        {
            var randomFact = await _apiService.GetRandomFactAsync();

        }
       
    }
}
