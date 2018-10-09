using System.Threading.Tasks;
using MagicPhotoProvider.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MagicPhotoProvider.Controllers
{
    [Route("[controller]")]
    public class PhotosController : Controller
    {
        private readonly IPhotoRepository PhotoRepository;

        public PhotosController(IPhotoRepository photoRepository)
        {
            PhotoRepository = photoRepository;
        }

        // GET photos/search
        [HttpGet("search/{limit=10}/{offset=0}")]
        public async Task<IActionResult> Search(int limit, int offset,[FromQuery] string keyword)
        {
            var photos = await PhotoRepository.Search(keyword, limit, offset);
            return Ok(photos);
        }
    }
}