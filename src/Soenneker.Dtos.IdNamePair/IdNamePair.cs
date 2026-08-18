using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.IdNamePair;

/// <summary>
/// Provides a compact API reference to another resource using its stable identifier and human-readable display name.
/// </summary>
[PublicOpenApiObject]
public record IdNamePair
{
    /// <summary>
    /// Stable unique identifier of the referenced resource.
    /// </summary>
    [Required]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public required string Id { get; set; } = null!;

    /// <summary>
    /// Human-readable display name of the referenced resource.
    /// </summary>
    [Required]
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public required string Name { get; set; } = null!;
}
