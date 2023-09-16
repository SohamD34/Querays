using System.Text.Json.Serialization;

namespace Querays.databases
{
    public class Book
    {
        public string Id { get; set; }
        public string Author { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public override string ToString() => System.Text.Json.JsonSerializer.Serialize<Book>(this);
    }
}
