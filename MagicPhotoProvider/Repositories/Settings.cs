using MagicPhotoProvider.Model;
using Microsoft.Extensions.Configuration;

namespace MagicPhotoProvider.Repositories
{
    public class Settings : ISettings
    {
        public Settings(IConfiguration configuration)
        {
            Configuration = configuration;
            this.APISettings =Configuration
                .GetSection(nameof(APISettings))
                .Get<APISettings>();
        }
        private APISettings APISettings = new APISettings();
        public IConfiguration Configuration { get; }
        public string PhotoProviderURL => APISettings.PhotoProviderURL;

        public string GifPath => APISettings.GifPath;

        public string APIKey => APISettings.APIKey;
    }
}
