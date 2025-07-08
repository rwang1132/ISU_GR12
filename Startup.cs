using RestSharp;
using System.Text.Json;

namespace ISU_Website
{
    public class Startup
    {
        //initializes api request
        public static readonly IRestClient client = new RestClient("https://api.ebird.org/v2/data/obs/CA-ON/recent").AddDefaultHeader("x-ebirdapitoken", "n9j4bgthu1e1");
        public static readonly RestRequest request = new RestRequest("https://api.ebird.org/v2/data/obs/CA-ON/recent", Method.Get);
    }
}
