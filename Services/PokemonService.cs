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

        // Método para obtener la lista de pokemones desde la API en línea
        public async Task<List<Pokemon>> ObtenerPokemonesAsync()
        {
            // Reemplaza la URL con la URL de la API externa
            var url = "https://www.jsondataai.com/api/SVH88dl";
            return await _httpClient.GetFromJsonAsync<List<Pokemon>>(url);
        }
    }
}
