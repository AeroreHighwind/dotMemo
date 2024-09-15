namespace dotMemo.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }

        public int Level { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Class { get; set; }

        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        public string background { get; set; }
        public string race { get; set; }

        public bool gender { get; set; }
    }
}
