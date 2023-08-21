using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        IColorService _colorService;

        public ColorController(IColorService colorService)
        {
            _colorService=colorService;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            var result = _colorService.GetAll();
            
                return Ok(result);
            
        }
    }
}
