using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvcprj.model;
using mvcprj.Services;

namespace mvcprj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }


        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return _characterService.Get(id);
        }

        [HttpGet]
        [Route("getall")]
        public List<Character> GetAll()
        {
            return _characterService.GetAll();
        }

        [HttpPost]
        public List<Character> AddCharacter(Character newCharacter)
        {
            return _characterService.AddCharacter(newCharacter);
        }

    }
}