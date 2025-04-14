using System.Text.Json.Serialization;

namespace ImageGallery.Payloads;

public record Image(
    string Url,
    string Caption,
    string Copyright
)
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("caption")]
    public required string Caption { get; init; }

    [JsonPropertyName("copyright")]
    public required string Copyright { get; init; }
}
