using Newtonsoft.Json;

namespace MagicPhotoProvider.Utilities
{
    public static class ContentHelper
    {
        public static T ToModel<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
