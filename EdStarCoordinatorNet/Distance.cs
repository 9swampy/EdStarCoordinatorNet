namespace EdStarCoordinatorNet
{
  using System;
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// Contains an origin system and a list of reference systems and their distances from the origin.
  /// </summary>
  public class Distance
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
    public DateTime CreateDate { get; set; }

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
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// Gets or sets the refs.
    /// </summary>
    /// <value>
    /// The refs.
    /// </value>
    [JsonProperty("refs")]
    public List<Ref> Refs { get; set; }
  }
}