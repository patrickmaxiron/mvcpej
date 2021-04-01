using AutoMapper;
using mvcprj.Dto.Character;
using mvcprj.model;

namespace mvcprj
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Character, GetCharacterDto>();
        }
    }
}