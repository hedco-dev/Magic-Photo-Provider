using System.Net.Http;
using System.Threading.Tasks;

namespace MagicPhotoProvider.Utilities
{
    public static class RequestHelper
    {
        public async static Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var responseResult = await response.Content.ReadAsStringAsync();
                return responseResult.ToModel<T>();
            }
        }
    }
}
