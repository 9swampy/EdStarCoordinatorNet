namespace EdStarCoordinatorNet
{
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// Defines a centred sphere.
  /// </summary>
  public class CoordSphere
  {
    /// <summary>
    /// Gets or sets the radius.
    /// </summary>
    /// <value>
    /// The radius.
    /// </value>
    [JsonProperty("radius")]
    public decimal Radius { get; set; }

    /// <summary>
    /// Gets or sets the origin of centre of the sphere.
    /// </summary>
    /// <value>
    /// The origin.
    /// </value>
    [JsonProperty("origin")]
    public List<int> Origin { get; set; }
  }
}