using System.Net.Http.Json;
using Taller3.Models;
using System.Text.Json;

namespace Taller3.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pokemon>> ObtenerPokemonesAsync()
        {
            var url = "https://www.jsondataai.com/api/SVH88dl";
            return await _httpClient.GetFromJsonAsync<List<Pokemon>>(url);
        }
    }
}
