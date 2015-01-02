namespace EdStarCoordinatorNet
{
  /// <summary>
  /// Output mode can be used to reduce bandwidth, as not all possible info is always required. A simple (Terse) list of names is fine for a dropdown list.
  /// </summary>
  public enum OutputModeOption
  {
    /// <summary>
    /// Output mode undefined.
    /// </summary>
    Undefined,

    /// <summary>
    /// A simple/terse response is required.
    /// </summary>
    Terse,

    /// <summary>
    /// An extended/verbose response is required.
    /// </summary>
    Verbose,
  }
}