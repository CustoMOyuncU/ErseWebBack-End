using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClotheImagesController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        IClotheImageService _clotheImageService;
        public ClotheImagesController(IWebHostEnvironment webHostEnvironment, IClotheImageService clotheImageService)
        {
            _webHostEnvironment = webHostEnvironment;
            _clotheImageService = clotheImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] ClotheImage clotheImage)
        {
            var result = _clotheImageService.Add(file, clotheImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ClotheImage clotheImage)
        {
            var result = _clotheImageService.Update(clotheImage);
            if (result.Success)
            {
                return Ok(clotheImage);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ClotheImage clotheImage)
        {
            var result = _clotheImageService.Delete(clotheImage);
            if (result.Success)
            {
                return Ok(clotheImage);
            }
            return BadRequest(result);
        }

        [HttpGet("getclotheimagebyclotheid")]
        public IActionResult GetCarImageByCarId(int id)
        {
            var result = _clotheImageService.GetByClotheId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _clotheImageService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getfilebyid")]
        public IActionResult GetFileById(int id)
        {
            var result = _clotheImageService.GetById(id);

            if (result.Success)
            {
                var f = System.IO.File.ReadAllBytes(result.Data.ImagePath);
                return File(f, "image/jpeg");
            }

            return BadRequest(result);
        }
    }
}
