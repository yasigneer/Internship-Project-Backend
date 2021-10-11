using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getalllist")]
        public IActionResult GetAllList()
        {
            var result = _personService.GetAllList();
            if (result.Success==true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpGet("favorites")]
        public IActionResult Favorites()
        {
            var result = _personService.Favorites();
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpGet("blockeds")]
        public IActionResult Blockeds()
        {
            var result = _personService.Blockeds();
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpGet("getbyname")]
        public IActionResult GetbyName(string name)
        {
            var result = _personService.GetbyName(name);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpGet("getbyphonenumber")]
        public IActionResult GetbyPhoneNumber(string number)
        {
            var result = _personService.GetbyPhoneNumber(number);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpGet("getbyphoto")]
        public IActionResult GetbyPhoto(string photoPath)
        {
            var result = _personService.GetbyPhoto(photoPath);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Person person)
        {
            var result = _personService.Update(person);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpPost("add")]
   
        public IActionResult Add(Person person)
        {
            var result = _personService.Add(person);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public  IActionResult Delete(Person person)
        {
            var result = _personService.Delete(person.Id);
            if (result.Success == true)
            {
                return Ok(result);
            };
            return BadRequest(result);
        }


    }
}
