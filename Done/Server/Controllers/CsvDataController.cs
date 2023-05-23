using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Done.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CsvDataController : ControllerBase
    {
        [HttpPost("upload")]
        public IActionResult UploadCsvFile(IFormFile file)
        {
            // Process the uploaded CSV file
            // You can save the file, validate it, and perform any additional operations

            // Example code for saving the uploaded CSV file
            if (file != null && file.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", file.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            return Ok();
        }
    }
}
