using System.Collections.Generic;
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

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public Character Get(int id)
        {
            return characters[id];
        }

        public List<Character> GetAll()
        {
            return characters;
        }
    }
}