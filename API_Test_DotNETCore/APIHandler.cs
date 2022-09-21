using System.Net.Http.Json;
using System.Text.Json;

namespace API_Test_DotNETCore
{
    internal class APIHandler
    {
        public static async Task<RootObject> GetDataAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetFromJsonAsync<RootObject>(url);
            }
        }
    }
}

