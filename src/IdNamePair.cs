using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdNamePair;

/// <summary>
/// A minimal Record type with an <see cref="Id"/> (string), <see cref="Name"/> (string), and maximum JSON compatibility. <para/>
/// The reason for this type (over something like KeyValuePair, dictionary) is because of JSON serialization support.
/// </summary>
/// <remarks>Record type, so avoid modification after initial construction.</remarks>
public record IdNamePair
{
    [Required]
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [Required]
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
}