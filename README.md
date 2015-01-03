EdStarCoordinatorNet
====================

A client library providing .Net access to the EdStarCoordinator POST/JSON Elite Dangerous community web service. The full web service and it's API is explained at http://edstarcoordinator.com/api.html. 

This library has been published as a NuGet package at https://www.nuget.org/packages/EdStarCoordinatorNet. I've NOT included the SubmitDistances method as I've not needed it yet; if you do feel free to implement and submit a pull request...

Example Usage
-------------

```C#
[TestMethod]
public void ShouldGetSystemsAroundSolByCoOrdCube()
{
  // Arrange
  GetRequest gsReq = new GetRequest();
  gsReq.Data = new RequestData();
  gsReq.Data.Ver = 2;
  gsReq.Data.OutputMode = OutputModeOption.Verbose;
  gsReq.Data.Filter = new Filter();
  gsReq.Data.Test = true;
  gsReq.Data.Filter.CoordCube = new List<List<int>>() { new List<int>() { -4, 4 }, new List<int>() { -4, 4 }, new List<int>() { -4, 4 } };
  gsReq.Data.Filter.Date = new DateTime(2010, 01, 01, 12, 00, 00);
  Client client = new Client();

  // Act
  GetSystemsResponse gsResponse = client.GetSystems(gsReq);

  // Assert
  gsResponse.Should().NotBeNull();
  gsResponse.Data.Should().NotBeNull();
  gsResponse.Data.Status.Should().NotBeNull();
  gsResponse.Data.Status.Input.Should().NotBeNull();
  gsResponse.Data.Status.Input.Count.Should().Be(1);
  gsResponse.Data.Status.Input.First().Status.Msg.Should().Be("Success");
  gsResponse.Data.Status.Input.First().Status.StatusNum.Should().Be(0);
  gsResponse.Data.Systems.Count.Should().Be(2);
  gsResponse.Data.Systems.First().Name.Should().Be("Alpha Centauri");
  gsResponse.Data.Systems.Last().Name.Should().Be("Sol");
}

[TestMethod]
public void ShouldGetDistancesForLhs1992()
{
  // Arrange
  GetRequest gsReq = new GetRequest();
  gsReq.Data = new RequestData();
  gsReq.Data.Ver = 2;
  gsReq.Data.OutputMode = OutputModeOption.Verbose;
  gsReq.Data.Filter = new Filter();
  gsReq.Data.Test = true;
  gsReq.Data.Filter.SystemName = "LHS 1992";
  //gsReq.Data.Filter.Date = "2010-09-18 12:34:56";
  gsReq.Data.Filter.Date = new DateTime(2010, 01, 01, 12, 00, 00);
  Client client = new Client();

  // Act
  GetDistancesResponse gsResponse = client.GetDistances(gsReq);

  // Assert
  gsResponse.Should().NotBeNull();
  gsResponse.Data.Should().NotBeNull();
  gsResponse.Data.Status.Should().NotBeNull();
  gsResponse.Data.Status.Input.Should().NotBeNull();
  gsResponse.Data.Status.Input.Count.Should().Be(1);
  gsResponse.Data.Status.Input.First().Status.Msg.Should().Be("Success");
  gsResponse.Data.Status.Input.First().Status.StatusNum.Should().Be(0);
  gsResponse.Data.Distances.Count.Should().Be(1);
  gsResponse.Data.Distances.Single().Name.Should().Be("LHS 1992");
  gsResponse.Data.Distances.Single().Refs.Count.Should().BeGreaterOrEqualTo(15);
  gsResponse.Data.Distances.Single().Refs.First().ConfidenceRating.Should().BeGreaterOrEqualTo(1);
  gsResponse.Data.Distances.Single().Refs.First().Dist.Should().BeGreaterThan(0);
  gsResponse.Data.Distances.Single().Refs.First().Coord.First().Should().NotBe(0);
}