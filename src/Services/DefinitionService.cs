using Apipedia.Models;
using System.Text.Json;

namespace Apipedia.Services
{
    public class DefinitionService
    {
        private HttpClient Http { get; }
        public List<Definition>? Definitions { get; private set; }

        public DefinitionService(HttpClient http)
        {
            Http = http;
        }

        public async Task LoadDefinitionsAsync()
        {
            if (Definitions == null)
            {
                var stream = await Http.GetStreamAsync("data/apidictionary.json");
                Definitions = await JsonSerializer.DeserializeAsync<List<Definition>>(stream);
            }
        }
    }
}
