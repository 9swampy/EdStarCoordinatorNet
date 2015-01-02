namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// An object containing the status of the response.
  /// </summary>
  public class ResponseStatus
  {
    /// <summary>
    /// Gets or sets the status number.
    /// </summary>
    /// <value>
    /// The status number.
    /// </value>
    [JsonProperty("statusnum")]
    public int StatusNum { get; set; }

    /// <summary>
    /// Gets or sets the status message.
    /// </summary>
    /// <value>
    /// The MSG.
    /// </value>
    [JsonProperty("msg")]
    public string Msg { get; set; }
  }
}