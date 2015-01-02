namespace EdStarCoordinatorNet
{
  using System;
  using System.Linq;
  using Newtonsoft.Json;

  /// <summary>
  /// Contains the parameters to send with a request.
  /// </summary>
  public class GetRequest
  {
    /// <summary>
    /// Gets or sets the data to be sent with the request.
    /// </summary>
    /// <value>
    /// The data.
    /// </value>
    [JsonProperty("data")]
    public RequestData Data { get; set; }

    /// <summary>
    /// Convert the request object to Json.
    /// </summary>
    /// <returns>A Json representation of the request.</returns>
    public string ToJson()
    {
      JsonSerializerSettings settings = new JsonSerializerSettings();
      settings.NullValueHandling = NullValueHandling.Ignore;
      return JsonConvert.SerializeObject(this, settings);
    }
  }
}