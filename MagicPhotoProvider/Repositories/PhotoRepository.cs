using System.Collections.Generic;
using System.Threading.Tasks;
using MagicPhotoProvider.Model;
using MagicPhotoProvider.Utilities;

namespace MagicPhotoProvider.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        public PhotoRepository(ISettings settings)
        {
            Settings = settings;
        }
        public ISettings Settings { get; }
        public async Task<Gighy> Search(string keyword, int limit = 10, int offset = 0)
        {
            var url = $"{Settings.PhotoProviderURL}{Settings.GifPath}?q={keyword}&api_key={Settings.APIKey}&limit={limit}&offset={offset}";
            return await RequestHelper.Get<Gighy>(url);
        }
    }
}