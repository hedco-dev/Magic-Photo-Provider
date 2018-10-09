namespace MagicPhotoProvider.Repositories
{
    public interface ISettings
    {
        string PhotoProviderURL { get; }
        string GifPath { get; }
        string APIKey { get; }
    }
}
