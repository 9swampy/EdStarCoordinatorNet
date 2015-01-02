namespace EdStarCoordinatorNet
{
  using System;
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// The data returned by a GetDistances request.
  /// </summary>
  public class DistancesData
  {
    /// <summary>
    /// Gets or sets version which must be sent with all requests. Only the Major version number. Minor version numbers of the API are always backwards compatible with the Major version.
    /// </summary>
    /// <value>
    /// The version.
    /// </value>
    [JsonProperty("ver")]
    public decimal Ver { get; set; }

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    /// <value>
    /// The date.
    /// </value>
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>
    /// The status.
    /// </value>
    [JsonProperty("status")]
    public InputStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the distances.
    /// </summary>
    /// <value>
    /// The distances.
    /// </value>
    [JsonProperty("distances")]
    public List<Distance> Distances { get; set; }
  }
}