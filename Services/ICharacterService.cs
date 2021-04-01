using System.Collections.Generic;
using mvcprj.model;

namespace mvcprj.Services
{
    public interface ICharacterService
    {
        public Character Get(int id);


        public List<Character> GetAll();

        public List<Character> AddCharacter(Character newCharacter);
    }
}