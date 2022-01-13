using System;

namespace Laba6
{
    class Tile
    {
        public string Name { get; set; }
        private readonly string description = null;
        public int PriceOfOnePack { get; set; }

        public Tile(string name, int price)
        {
            this.Name = name;
            this.PriceOfOnePack = price;
        }

        public override string ToString()
        {
            return $"{Name}    {PriceOfOnePack}";
        }
    }
}
