using System.Text.Json.Serialization;

namespace Apipedia.Models
{
    public class Definition
    {
        [JsonPropertyName("key")]
        public required string Key { get; set; }
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("htmlDef")]
        public string? HtmlDef { get; set; }
        [JsonPropertyName("refs")]
        public List<Reference>? Refs { get; set; }
        [JsonPropertyName("tags")]
        public List<Tag>? Tags { get; set; }
        [JsonPropertyName("imgs")]
        public List<Img>? Imgs { get; set; }
    }

    public class Reference
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class Tag
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("category")]
        public string? Category { get; set; }
    }

    public class Img
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
