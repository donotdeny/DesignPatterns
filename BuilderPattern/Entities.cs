using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        public string Model { get; set; } = string.Empty;
        public int NumberOfSeat { get; set; }  
        public string Engine { get; set; } = string.Empty;
        public bool Turbo { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}, Number of seat: {NumberOfSeat}, Engine: {Engine}, Turbo: {Turbo}";
        }
    }
}
