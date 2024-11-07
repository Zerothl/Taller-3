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
            // Lee el archivo JSON desde la carpeta wwwroot
            return await _httpClient.GetFromJsonAsync<List<Pokemon>>("pokemones.json");
        }
    }
}
