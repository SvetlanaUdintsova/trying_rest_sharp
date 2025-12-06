using RestSharp;

namespace TryingRestSharp;

public class UnitTest1
{
    [Fact]
    public void SimpleHealthzChech()
    {
        var client = new RestClient("https://api.met.no/weatherapi/locationforecast/2.0");
        var request = new RestRequest("/healthz", Method.Get);
        var response = client.Execute(request);

        Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}
