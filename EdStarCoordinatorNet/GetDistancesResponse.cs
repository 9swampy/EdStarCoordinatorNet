namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// A GetDistances response object.
  /// </summary>
  public class GetDistancesResponse
  {
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>
    /// The data.
    /// </value>
    [JsonProperty("d")]
    public DistancesData Data { get; set; }
  }
}