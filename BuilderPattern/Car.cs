namespace BuilderPattern
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public bool Gear { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Km} - {Gear}";
        }
    }
}