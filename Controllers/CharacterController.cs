using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcprj.model;
using mvcprj.Services;

namespace mvcprj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Character>>  Get(int id)
        {
            return Ok(await _characterService.Get(id));
        }

        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult<List<Character>>> GetAll()
        {
            return Ok(await _characterService.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

    }
}