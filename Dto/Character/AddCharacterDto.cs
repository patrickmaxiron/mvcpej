using mvcprj.model;

namespace mvcprj.Dto.Character
{
    public class AddCharacterDto
    {
        

        public string Name { get; set; } = "Tast";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class = RpgClass.Knight;
    }
}