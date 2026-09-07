using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCatFactsApp.Models
{
    public class RandomFact
    {
        public required string Fact { get; set; }
        public required int Length { get; set; }
    }
}

