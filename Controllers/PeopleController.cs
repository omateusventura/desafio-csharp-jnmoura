using API.Infra.Repositories;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleRepository _peopleRepository;

        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PeopleEntity>>> findAll()
        {
            List<PeopleEntity> peoples = await _peopleRepository.findAll();
            return Ok(peoples);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PeopleEntity>> findById(int id)
        {
            PeopleEntity people = await _peopleRepository.findById(id);
            return Ok(people);
        }

        [HttpPost]
        public async Task<ActionResult<PeopleEntity>> add([FromBody] PeopleEntity people)
        {
            PeopleEntity response = await _peopleRepository.add(people);
            return Ok(response);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PeopleEntity>> update([FromBody] PeopleEntity people, int id)
        {
            PeopleEntity response = await _peopleRepository.update(people, id);
            return Ok(response);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> delete(int id)
        {
            bool response = await _peopleRepository.delete(id);
            return Ok(response);
        }
    }
}
