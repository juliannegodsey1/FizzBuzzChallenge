using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace API_Exercise_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

        }

    }
}
