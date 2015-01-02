namespace EdStarCoordinatorNet
{
  using System;
  using System.IO;
  using System.Net;

  /// <summary>
  /// A client providing access to the EdStarCoordinator POST/JSON community web service.
  /// </summary>
  public class Client
  {
    private const string BaseUrl = @"http://edstarcoordinator.com/api.asmx";

    /// <summary>
    /// Get a list of systems.
    /// </summary>
    /// <param name="request">The request parameters.</param>
    /// <returns>Returns an object with current API version (decimal value), date of data request, a status object and a list of systems, with corresponding data.</returns>
    public GetSystemsResponse GetSystems(GetRequest request)
    {
      string jsonResponse;
      this.Post(string.Format("{0}/GetSystems", BaseUrl), request.ToJson(), out jsonResponse);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<GetSystemsResponse>(jsonResponse);
    }

    /// <summary>
    /// Gets a list of Distances.
    /// </summary>
    /// <param name="request">The request parameters.</param>
    /// <returns>Returns an object with current API version (decimal value), date of data request, a status object and a list of systems, with corresponding data. 
    /// The data consists of a "header" system (p0) to which the included list (refs) of distances are measured.</returns>
    public GetDistancesResponse GetDistances(GetRequest request)
    { 
      string jsonResponse;
      this.Post(string.Format("{0}/GetDistances", BaseUrl), request.ToJson(), out jsonResponse);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<GetDistancesResponse>(jsonResponse);
    }

    private long Post(string url, string jsonRequest, out string jsonResponse)
    {
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      request.Method = "POST";

      System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
      byte[] byteArray = encoding.GetBytes(jsonRequest);

      request.ContentLength = byteArray.Length;
      request.ContentType = @"application/json; charset=utf-8";

      using (Stream dataStream = request.GetRequestStream())
      {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }

      long length = 0;
      try
      {
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        {
          length = response.ContentLength;
          StreamReader sr = new StreamReader(response.GetResponseStream());
          jsonResponse = sr.ReadToEnd();
          return length;
        }
      }
      catch (WebException ex)
      {
        System.Diagnostics.Debug.Print(ex.Message);
        throw;
      }
    }
  }
}