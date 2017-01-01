using System.Collections.Generic;

namespace SetFinderLib
{
    class Deck
    {
        private Queue<Card> cards;

        public IEnumerable<Card> Deal()
        {
            if (cards.Count > 0)
            {
                yield return cards.Dequeue();
            }           
        }

        public Deck()
        {
            var list = new List<Card>();

            foreach (var symbol in EnumUtil.GetValues<Symbol>())
            {
                foreach (var color in EnumUtil.GetValues<Color>())
                {
                    foreach (var number in EnumUtil.GetValues<Number>())
                    {
                        foreach (var shading in EnumUtil.GetValues<Shading>())
                        {
                            list.Add(new Card
                            {
                                Symbol = symbol,
                                Color = color,
                                Number = number,
                                Shading = shading
                            });
                        }
                    }
                }
            }

            list.Shuffle();

            this.cards = new Queue<Card>(list);
        }
    }
}
