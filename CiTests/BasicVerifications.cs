namespace EdStarCoordinatorNet.CiTests
{
  using FluentAssertions;
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  [TestClass]
  public class BasicVerifications
  {
    [TestMethod]
    public void FullGetRequestShouldSerializeTo()
    {
      GetRequest gsReq = FullGetRequest();
      string jsonRequest = gsReq.ToJson();
      jsonRequest.Should().Be("{\"data\":{\"ver\":2,\"test\":true,\"outputmode\":2,\"filter\":{\"systemname\":\"sol\",\"date\":\"2014-01-01T12:00:00\"}}}");
    }

    [TestMethod]
    public void FullGetSystemsRequestShouldRespond()
    {
      // Arrange
      GetRequest gsReq = FullGetRequest();
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
      gsResponse.Data.Systems.Should().NotBeNull();
      gsResponse.Data.Systems.Count().Should().BeGreaterOrEqualTo(8);
      gsResponse.Data.Systems.Count(o => o.Name == "Sol").Should().Be(1);
      StarSystem sol = gsResponse.Data.Systems.Single(o => o.Name == "Sol");
      sol.Coord.First().Should().Be(0.0M);
      sol.Coord.Skip(1).First().Should().Be(0.0M);
      sol.Coord.Last().Should().Be(0.0M);
    }

    private static GetRequest FullGetRequest()
    {
      GetRequest gsReq = new GetRequest();
      gsReq.Data = new EdStarCoordinatorNet.RequestData();
      gsReq.Data.OutputMode = OutputModeOption.Verbose;
      gsReq.Data.Test = true;
      gsReq.Data.Ver = 2;
      gsReq.Data.Filter = new Filter();
      //gsReq.Data.Filter.Date = "2014-01-01 12:00:00";
      gsReq.Data.Filter.Date = new DateTime(2014, 01, 01, 12, 00, 00);
      gsReq.Data.Filter.SystemName = "sol";
      return gsReq;
    }

    private static GetRequest FullSolGetRequest()
    {
      GetRequest gsReq = new GetRequest();
      gsReq.Data = new EdStarCoordinatorNet.RequestData();
      gsReq.Data.OutputMode = OutputModeOption.Verbose;
      gsReq.Data.Test = true;
      gsReq.Data.Ver = 2;
      gsReq.Data.Filter = new Filter();
      //gsReq.Data.Filter.Date = "2014-01-01 12:00:00";
      gsReq.Data.Filter.Date = new DateTime(2014, 01, 01, 12, 00, 00);
      gsReq.Data.Filter.SystemName = "sol";
      gsReq.Data.Filter.KnownStatus = KnownSystemOption.All;
      gsReq.Data.Filter.ConfidenceRating = 5;
      gsReq.Data.Filter.CoordCube = new System.Collections.Generic.List<System.Collections.Generic.List<int>>();
      gsReq.Data.Filter.CoordCube.Add(new System.Collections.Generic.List<int>() { -10, 10 });
      gsReq.Data.Filter.CoordCube.Add(new System.Collections.Generic.List<int>() { -10, 10 });
      gsReq.Data.Filter.CoordCube.Add(new System.Collections.Generic.List<int>() { -10, 10 });
      gsReq.Data.Filter.CoordSphere = new CoordSphere() { Radius = 123.45M, Origin = new System.Collections.Generic.List<int>() { 10, 20, 30 } };
      return gsReq;
    }

    [TestMethod]
    public void SimplestGetRequestShouldSerializeTo()
    {
      GetRequest gsReq = SimplestGetRequest();
      string json = gsReq.ToJson();
      json.Should().Be("{\"data\":{\"ver\":2}}");
    }

    [TestMethod]
    public void SimplestGetSystemsRequestShouldRespond()
    {
      // Arrange
      GetRequest gsReq = SimplestGetRequest();
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
    }

    private static GetRequest SimplestGetRequest()
    {
      GetRequest gsReq = new GetRequest();
      gsReq.Data = new EdStarCoordinatorNet.RequestData();
      gsReq.Data.Ver = 2;
      return gsReq;
    }

    [TestMethod]
    public void SimplestGetDistancesRequestShouldRespond()
    {
      // Arrange
      GetRequest gsReq = SimplestGetRequest();
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
    }

    [TestMethod]
    public void FullGetDistancesRequestShouldSerializeTo()
    {
      // Arrange
      GetRequest gsReq = FullSolGetRequest();

      // Act
      string jsonRequest = gsReq.ToJson();

      // Assert
      jsonRequest.Should().Be("{\"data\":{\"ver\":2,\"test\":true,\"outputmode\":2,\"filter\":{\"knownstatus\":0,\"systemname\":\"sol\",\"cr\":5,\"date\":\"2014-01-01T12:00:00\",\"coordcube\":[[-10,10],[-10,10],[-10,10]],\"coordsphere\":{\"radius\":123.45,\"origin\":[10,20,30]}}}}");
    }

    [TestMethod]
    public void FullGetDistancesRequestShouldRespond()
    {
      // Arrange
      GetRequest gsReq = FullSolGetRequest();
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
      gsResponse.Data.Distances.Should().NotBeNull();
      gsResponse.Data.Distances.Count.Should().Be(0);
    }

    [TestMethod]
    public void ShouldGetSystemsAroundSolByCoOrdSphere()
    {
      // Arrange
      GetRequest gsReq = new GetRequest();
      gsReq.Data = new RequestData();
      gsReq.Data.Ver = 2;
      gsReq.Data.OutputMode = OutputModeOption.Verbose;
      gsReq.Data.Filter = new Filter();
      gsReq.Data.Test = true;
      //gsReq.Data.Filter.Date = "2010-09-18 12:34:56";
      gsReq.Data.Filter.Date = new DateTime(2010, 01, 01, 12, 00, 00);
      gsReq.Data.Filter.CoordSphere = new CoordSphere() { Radius = 5M, Origin = new System.Collections.Generic.List<int>() { 0, 0, 0 } };
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
  }
}
