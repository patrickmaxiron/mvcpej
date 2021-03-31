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

        
        public Character Get()
        {
            return characters[1];
        }

        [HttpGet]
        [Route("getall")]
        public List<Character> GetAll()
        {
            return characters;
        }

    }
}