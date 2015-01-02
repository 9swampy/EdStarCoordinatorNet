namespace EdStarCoordinatorNet
{
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// The data returned by a GetSystems request.
  /// </summary>
  public class SystemsData
  {
    /// <summary>
    /// Gets or sets version which must be sent with all requests. Only the Major version number. Minor version numbers of the API are always backwards compatible with the Major version.
    /// </summary>
    /// <value>
    /// The version.
    /// </value>
    [JsonProperty("ver")]
    public double Ver { get; set; }

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    /// <value>
    /// The date.
    /// </value>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>
    /// The status.
    /// </value>
    [JsonProperty("status")]
    public InputStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the systems.
    /// </summary>
    /// <value>
    /// The systems.
    /// </value>
    [JsonProperty("systems")]
    public List<StarSystem> Systems { get; set; }
  }
}