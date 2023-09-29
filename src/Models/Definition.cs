using YamlDotNet.Serialization;

namespace Apipedia.Models
{
    public class Definition
    {
        [YamlMember(Alias = "key")]
        public required string Key { get; set; }
        [YamlMember(Alias = "title")]
        public required string Title { get; set; }
        [YamlMember(Alias = "htmlDef")]
        public string? HtmlDef { get; set; }
        [YamlMember(Alias = "refs")]
        public List<Reference>? Refs { get; set; }
        [YamlMember(Alias = "tags")]
        public List<Tag>? Tags { get; set; }
        [YamlMember(Alias = "imgs")]
        public List<Img>? Imgs { get; set; }
    }

    public class Reference
    {
        [YamlMember(Alias = "title")]
        public string? Title { get; set; }
        [YamlMember(Alias = "url")]
        public string? Url { get; set; }
    }

    public class Tag
    {
        [YamlMember(Alias = "name")]
        public string? Name { get; set; }
        [YamlMember(Alias = "category")]
        public string? Category { get; set; }
    }

    public class Img
    {
        [YamlMember(Alias = "title")]
        public string? Title { get; set; }
        [YamlMember(Alias = "url")]
        public string? Url { get; set; }
    }

}
