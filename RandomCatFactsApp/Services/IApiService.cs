using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCatFactsApp.Services
{
    public interface IApiService
    {
        Task<string> GetRandomFactAsync();
    }
}
