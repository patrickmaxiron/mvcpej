using System.Collections.Generic;
using System.Threading.Tasks;
using mvcprj.model;

namespace mvcprj.Services
{
    public class CharacterService : ICharacterService
    {

        private List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Id = 1,
                Name = "Patrick",
            }
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<Character> Get(int id)
        {
            return characters[id];
        }

        public async Task<List<Character>> GetAll()
        {
            return characters;
        }
    }
}