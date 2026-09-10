using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Http;

namespace RandomCatFactsApp.Controller
{
    internal class FileTxtSaver
    {
        private readonly IConfiguration _configuration;
        private readonly string _filePath;
    }
}
