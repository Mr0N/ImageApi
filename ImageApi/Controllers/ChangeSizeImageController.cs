using ImageApi.Models;
using Logica.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ImageApi.Controllers
{
    [ApiController]
    public class ChangeSizeImageController : ControllerBase
    {
        [HttpPost("changeSize")]
        public IActionResult Index([FromForm][NotNull] SizeInfo infoOfImage)
        {
            if (infoOfImage.width == 0 ||
                infoOfImage.width == 0 ||
                infoOfImage.image is null || 
                infoOfImage.image.Length == 0)
                return NotFound();
            try
            {
                using var streamRead = infoOfImage.image.OpenReadStream();
                var streamImage = _change.ChangeSizeImage(streamRead, infoOfImage.width, infoOfImage.height);
                return File(streamImage, "image/png", $"image-{infoOfImage.width}-{infoOfImage.height}.png");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return NotFound("An error occurred while converting your image");
            }
        }
        IChangeImageSize _change;
        ILogger<ChangeSizeImageController> _logger;
        public ChangeSizeImageController(IChangeImageSize change, ILogger<ChangeSizeImageController> logger)
        {
            _change = change;
            _logger = logger;
        }
    }
}
