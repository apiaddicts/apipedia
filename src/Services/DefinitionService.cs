using Apipedia.Models;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

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
                var yaml = new YamlStream();
                var response = await Http.GetAsync("data/apidictionary.yaml");
                var yamlString = await response.Content.ReadAsStringAsync();
                yaml.Load(new StringReader(yamlString));
                var deserializer = new DeserializerBuilder().Build();
                Definitions = deserializer.Deserialize<List<Definition>>(yamlString);
            }
        }
    }
}
