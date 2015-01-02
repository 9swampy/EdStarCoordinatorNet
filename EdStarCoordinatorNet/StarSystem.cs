namespace EdStarCoordinatorNet
{
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// Defines properties of a single Star System.
  /// </summary>
  public class StarSystem
  {
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    [JsonProperty("id")]
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the coordinate.
    /// </summary>
    /// <value>
    /// The coordinate.
    /// </value>
    [JsonProperty("coord")]
    public List<decimal> Coord { get; set; }

    /// <summary>
    /// Gets or sets the confidence rating: How many times have an entry been confirmed. With a cr of 1 it could be a mistyped system name. The chance of which is reduced with a higher cr number. Records with a cr equal or higher than the supplied value are returned.
    /// </summary>
    /// <value>
    /// The confidence rating.
    /// </value>
    [JsonProperty("cr")]
    public int ConfidenceRating { get; set; }

    /// <summary>
    /// Gets or sets the creating commander.
    /// </summary>
    /// <value>
    /// The creating commander.
    /// </value>
    [JsonProperty("commandercreate")]
    public string CommanderCreate { get; set; }

    /// <summary>
    /// Gets or sets the create date.
    /// </summary>
    /// <value>
    /// The create date.
    /// </value>
    [JsonProperty("createdate")]
    public string CreateDate { get; set; }

    /// <summary>
    /// Gets or sets the commander responsible for the update.
    /// </summary>
    /// <value>
    /// The updating commander.
    /// </value>
    [JsonProperty("commanderupdate")]
    public string CommanderUpdate { get; set; }

    /// <summary>
    /// Gets or sets the update date.
    /// </summary>
    /// <value>
    /// The update date.
    /// </value>
    [JsonProperty("updatedate")]
    public string UpdateDate { get; set; }
  }
}