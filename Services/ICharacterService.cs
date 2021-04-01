using System.Collections.Generic;
using System.Threading.Tasks;
using mvcprj.model;

namespace mvcprj.Services
{
    public interface ICharacterService
    {
        public  Task<Character> Get(int id);


        public  Task<List<Character>> GetAll();

        public  Task<List<Character>> AddCharacter(Character newCharacter);
    }
}