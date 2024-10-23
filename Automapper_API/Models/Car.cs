namespace Automapper_API.Models
{
    public class Car
    {
        public string Brand { get; set; } = default!;
        public int Power { get; set; }
        public string Model { get; set; } = default!;
        public string Color { get; set; } = default!;
    }
}
