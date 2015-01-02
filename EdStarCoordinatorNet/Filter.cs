namespace EdStarCoordinatorNet
{
  using System;
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// Filter is an object wrapping the individual filter options. Filter options are applied to p0, and not the Ref systems.
  /// </summary>
  public class Filter
  {
    /// <summary>
    /// Gets or sets the known status, which filters on if a systems coordinates are known or not.
    /// </summary>
    /// <value>
    /// The known status.
    /// </value>
    [JsonProperty("knownstatus")]
    public KnownSystemOption? KnownStatus { get; set; }

    /// <summary>
    /// Gets or sets the name of the system. Limits search to systems with names containing <see cref="systemname"/>.
    /// </summary>
    /// <value>
    /// The name of the system.
    /// </value>
    [JsonProperty("systemname")]
    public string SystemName { get; set; }

    /// <summary>
    /// Gets or sets the confidence rating: How many times have an entry been confirmed. With a cr of 1 it could be a mistyped system name. The chance of which is reduced with a higher cr number. Records with a cr equal or higher than the supplied value are returned.
    /// </summary>
    /// <value>
    /// The confidence rating.
    /// </value>
    [JsonProperty("cr")]
    public int? ConfidenceRating { get; set; }

    /// <summary>
    /// Gets or sets the date. Defaults to Now - 24hrs if not set.
    /// </summary>
    /// <value>
    /// The date.
    /// </value>
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets the coordinate cube. Limits the results to those star systems contained by the defined cube.
    /// </summary>
    /// <value>
    /// The coordinate cube.
    /// </value>
    [JsonProperty("coordcube")]
    public List<List<int>> CoordCube { get; set; }

    /// <summary>
    /// Gets or sets the coordinate sphere. Limits the result to those StarSystems within the given radius of the origin.
    /// </summary>
    /// <value>
    /// The coordinate sphere.
    /// </value>
    [JsonProperty("coordsphere")]
    public CoordSphere CoordSphere { get; set; }
  }
}