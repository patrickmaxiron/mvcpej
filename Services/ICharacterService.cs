using System.Collections.Generic;
using System.Threading.Tasks;
using mvcprj.model;

namespace mvcprj.Services
{
    public interface ICharacterService
    {
        public  Task<ServiceResponse<Character>> Get(int id);


        public  Task<ServiceResponse<List<Character>>> GetAll();

        public  Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}