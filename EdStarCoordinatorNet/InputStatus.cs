namespace EdStarCoordinatorNet
{
  using System.Collections.Generic;
  using Newtonsoft.Json;

  /// <summary>
  /// The parse status of the input request.
  /// </summary>
  public class InputStatus
  {
    /// <summary>
    /// Gets or sets the input.
    /// </summary>
    /// <value>
    /// The input.
    /// </value>
    [JsonProperty("input")]
    public List<Input> Input { get; set; }
  }
}