namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// Properties of the star and it's distance from the referenced origin.
  /// </summary>
  public class Ref : StarSystem
  {
    /// <summary>
    /// Gets or sets the distance from the referenced origin.
    /// </summary>
    /// <value>
    /// The distance.
    /// </value>
    [JsonProperty("dist")]
    public decimal Dist { get; set; }
  }
}