using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiHomeWork.Utils
{
    public class AnimeAPI
    {
        private readonly HttpClient _client;

        public AnimeAPI(string baseAddress)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        public async Task<string> GetRandomQuote()
        {
            return await GetAnimeQuotes("random");
        }

        public async Task<string> GetQuoteByName(string animeTitle)
        {
            return await GetAnimeQuotes("quotes/anime?title=" + animeTitle);
        }

        public async Task<string> GetQuoteByCharacterName(string characterName)
        {
            return await GetAnimeQuotes("quotes/character?name=" + characterName);
        }

        private async Task<string> GetAnimeQuotes(string endpoint)
        {
            string result;
            HttpResponseMessage response = await _client.GetAsync(endpoint);
            try
            {
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch(Exception ex)
            {
                if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    result = "Could not find quote!";
                } else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    result = "Please enter name!";
                }
                else
                {
                    result = ex.Message;
                }
            } 
            return result;
        }
    }
}
