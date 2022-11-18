using Microsoft.AspNetCore.Mvc;

namespace H4ImageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        ImageToBase64 imageToBase64;
        [Route("[action]")]
        [HttpGet]
        public IActionResult GetImage()
        {
            try
            {
                imageToBase64 = new ImageToBase64();
                return Ok(imageToBase64.ToBase64());
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
        [Route("[action]")]
        [HttpPost]
        public IActionResult SaveImage([FromForm] string base64)
        {
            try
            {
                imageToBase64 = new ImageToBase64();
                return Ok(imageToBase64.SaveBase64Image(base64));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
