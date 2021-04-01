using System.Collections.Generic;
using System.Threading.Tasks;
using mvcprj.Dto.Character;
using mvcprj.model;

namespace mvcprj.Services
{
    public interface ICharacterService
    {
        public  Task<ServiceResponse<GetCharacterDto>> Get(int id);


        public  Task<ServiceResponse<List<GetCharacterDto>>> GetAll();

        public  Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);


        public  Task<ServiceResponse<GetCharacterDto>> Update(UpdateCharacterDto updateCharacterDto);
    }
}