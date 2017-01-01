using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetFinderLib
{
    public class Card
    {
        public Shading Shading { get; set; }
        public Symbol Symbol { get; set; }
        public Color Color { get; set; }
        public Number Number { get; set; }

        public Card() {}

        public Card(Shading shading, Symbol symbol, Color color, Number number)
        {
            this.Shading = shading;
            this.Symbol = symbol;
            this.Color = color;
            this.Number = number;
        }
    }

    public enum Shading
    {
        Solid,
        Striped,
        Open
    }

    public enum Symbol
    {
        Diamond,
        Squiggle,
        Oval
    }

    public enum Color
    {
        Red,
        Green,
        Purple
    }

    public enum Number
    {
        One = 1,
        Two,
        Three
    }
}