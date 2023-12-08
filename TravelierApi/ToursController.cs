using Microsoft.AspNetCore.Mvc;

namespace TravelierApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly IToursRepository _toursRepository;

        public ToursController(IToursRepository toursRepository)
        {
            _toursRepository = toursRepository;
        }

        [HttpGet("Get All")]
        public IActionResult GetTours()
        {
            var tours = _toursRepository.GetAllTours();
            return Ok(tours);
        }

        [HttpGet("{id}")]
        public IActionResult GetToursById(int id)
        {
            var tours = _toursRepository.GetToursById(id);
            if (tours == null)
            {
                return NotFound();
            }
            return Ok(tours);
        }

        [HttpPost("Create Tour")]
        public IActionResult CreateTours([FromBody] Tours tours)
        {
            if (tours == null)
            {
                return BadRequest();
            }
            _toursRepository.CreateTours(tours);
            return Ok(tours);
        }

        [HttpPut("Update Tour/{id}")]
        public IActionResult UpdateTours(int id, [FromBody] Tours tours)
        {
            if (tours == null)
            {
                return BadRequest();
            }
            _toursRepository.UpdateTours(id, tours);
            return Ok(tours);
        }

        [HttpDelete("Delete Tour/{id}")]
        public IActionResult DeleteTours(int id)
        {
            _toursRepository.DeleteTours(id);
            return Ok();
        }
    }
}
