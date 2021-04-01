using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvcprj.model;

namespace mvcprj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController
    {

        private List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Id = 1,
                Name = "Patrick",
            }
        };

        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return characters[id];
        }

        [HttpGet]
        [Route("getall")]
        public List<Character> GetAll()
        {
            return characters;
        }

        [HttpPost]
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

    }
}