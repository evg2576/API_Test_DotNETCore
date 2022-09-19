using System.Net.Http.Json;

namespace API_Test_DotNETCore
{
    internal class APIHandler
    {
        public static async Task<T> GetData<T>(string url)
        {
            using var httpClient = new HttpClient();
            return await httpClient.GetFromJsonAsync<T>(url);
        }

    }
}

