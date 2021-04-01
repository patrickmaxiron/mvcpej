using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using mvcprj.Dto.Character;
using mvcprj.model;



//update

namespace mvcprj.Services
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Id = 1,
                Name = "Patrick",
            }
        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;

        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();

            Character c = _mapper.Map<Character>(newCharacter);

            int Id = characters.Max(c => c.Id);

            c.Id = Id + 1;

            characters.Add(c);

            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> Get(int Id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();

            Character c = characters.FirstOrDefault(c => c.Id == Id);

            serviceResponse.Data = _mapper.Map<GetCharacterDto>(c);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();

            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> Update(UpdateCharacterDto updateCharacterDto)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();

            try
            {
                Character c = characters.FirstOrDefault(c => c.Id == updateCharacterDto.Id);

                c.Name = updateCharacterDto.Name;
                c.Strength = updateCharacterDto.Strength;
                c.Intelligence = updateCharacterDto.Strength;
                c.HitPoints = updateCharacterDto.HitPoints;
                c.Defense = updateCharacterDto.Defense;
                c.Class = updateCharacterDto.Class;

                serviceResponse.Data = _mapper.Map<GetCharacterDto>(c);
                return serviceResponse;
            }catch(Exception e){
                serviceResponse.Success=false;
                serviceResponse.Message = e.Message;
                return serviceResponse;
            }




        }
    }
}