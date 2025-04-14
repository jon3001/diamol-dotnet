using System.Text.Json.Serialization;

namespace ImageGallery.Payloads;

public record Accesslog(
    string ClientIP
)
{
    [JsonPropertyName("clientIp")]
    public required string ClientIP { get; init; }
}
