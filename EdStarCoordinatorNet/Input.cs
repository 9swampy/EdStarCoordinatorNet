namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// Contains a status object.
  /// </summary>
  public class Input
  {
    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>
    /// The status.
    /// </value>
    [JsonProperty("status")]
    public ResponseStatus Status { get; set; }
  }
}