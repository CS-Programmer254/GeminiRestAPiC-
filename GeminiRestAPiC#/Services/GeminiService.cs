using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GeminiRestAPiC_.Services
{
    public class GeminiService :IGeminiService
    {
        private readonly HttpClient _httpClient;

        public GeminiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GenerateContentAsync(string text)
        {
            var userDataQuery= new { text };
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5000/generate",userDataQuery);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }

}
