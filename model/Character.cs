namespace mvcprj.model
{
    public class Character
    {
        public int id { get; set; } 

        public string name { get; set; }

        public int hitPoints { get; set; } = 100;

        public int strength { get; set; } = 10;

        public int defense { get; set; } = 10;

        public int intelligence { get; set; } = 10;

        
    }
}