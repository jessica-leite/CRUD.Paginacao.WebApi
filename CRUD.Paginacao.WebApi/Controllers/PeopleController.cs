using CRUD.Paginacao.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD.Paginacao.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult Create(People people)
        {
            _repository.Create(people);

            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var people = _repository.GetById(id);

            if (people == null)
            {
                return NotFound();
            }

            return Ok(people);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _repository.Delete(id);

            return NoContent();
        }

        [HttpGet("name/{name}")]
        public ActionResult GetAllByFilter(string name)
        {
            var peoples = _repository.GetAllByFilter(name);

            if (!peoples.Any())
            {
                return NotFound();
            }

            return Ok(peoples);
        }
    }
}
