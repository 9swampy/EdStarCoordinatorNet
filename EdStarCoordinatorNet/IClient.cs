using System;
namespace EdStarCoordinatorNet
{
  public interface IClient
  {
    GetDistancesResponse GetDistances(GetRequest request);
    GetSystemsResponse GetSystems(GetRequest request);
  }
}
