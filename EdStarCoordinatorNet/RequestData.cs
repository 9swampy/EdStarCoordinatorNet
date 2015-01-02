namespace EdStarCoordinatorNet
{
  using Newtonsoft.Json;

  /// <summary>
  /// The data to be sent with the request.
  /// </summary>
  public class RequestData
  {
    /// <summary>
    /// Gets or sets version which must be sent with all requests. Only the Major version number. Minor version numbers of the API are always backwards compatible with the Major version.
    /// </summary>
    /// <value>
    /// The version.
    /// </value>
    [JsonProperty("ver")]
    public int Ver { get; set; }

    /// <summary>
    /// Gets or sets the test flag. When test is true all queries are directed at a test DB.
    /// The test DB is a mirror of the non-test DB and is being mirrored every 24 hours at 1:15 UTC.
    /// Please use the test flag when developing your apps, so we get as little trash as possible in the non-test DB.
    /// </summary>
    /// <value>
    /// The test flag.
    /// </value>
    [JsonProperty("test")]
    public bool? Test { get; set; }

    /// <summary>
    /// Gets or sets the output mode. Output mode can be used to reduce bandwidth, as not all possible info is always required. A simple (Terse) list of names is fine for a dropdown list.
    /// </summary>
    /// <value>
    /// The output mode.
    /// </value>
    [JsonProperty("outputmode")]
    public OutputModeOption? OutputMode { get; set; }

    /// <summary>
    /// Gets or sets the filter. Filter is an object wrapping the individual filter options. Filter options are applied to p0, and not the Ref systems.
    /// </summary>
    /// <value>
    /// The filter.
    /// </value>
    [JsonProperty("filter")]
    public Filter Filter { get; set; }
  }
}