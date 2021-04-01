using System.Collections.Generic;
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
        public ActionResult<Character>  Get(int id)
        {
            return Ok(_characterService.Get(id));
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characterService.GetAll());
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }

    }
}