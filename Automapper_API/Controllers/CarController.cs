using AutoMapper;
using Automapper_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Automapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CarController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Add(CarRequest request)
        { 
            Car car = _mapper.Map<Car>(request);

            return Ok(car);
        }

    }
}
