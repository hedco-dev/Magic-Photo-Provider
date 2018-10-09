using MagicPhotoProvider.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicPhotoProvider.Repositories
{
    public interface IPhotoRepository
    {
        Task<Gighy> Search(string keyword, int limit = 10, int offset = 0);
    }
}