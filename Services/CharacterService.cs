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

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();

            characters.Add(newCharacter);

            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> Get(int id)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();

            serviceResponse.Data = characters[id];
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAll()
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();


            serviceResponse.Data = characters;
            return serviceResponse;
        }
    }
}