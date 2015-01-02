namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// A GetSystems response object.
  /// </summary>
  public class GetSystemsResponse
  {
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>
    /// The data.
    /// </value>
    [JsonProperty("d")]
    public SystemsData Data { get; set; }
  }
}