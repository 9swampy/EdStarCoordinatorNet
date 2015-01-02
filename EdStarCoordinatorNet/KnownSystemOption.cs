namespace EdStarCoordinatorNet
{
  /// <summary>
  /// Used to filter on if a systems coordinates are known or not.
  /// </summary>
  public enum KnownSystemOption
  {
    /// <summary>
    /// Include all.
    /// </summary>
    All,

    /// <summary>
    /// Include only the known.
    /// </summary>
    Known,

    /// <summary>
    /// Include only the unknown.
    /// </summary>
    Unknown,
  }
}