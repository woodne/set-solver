using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics.Collections;

namespace SetFinderLib
{
    public class Table
    {
        public HashSet<Card> Cards;

        private Deck deck;

        public bool MatchExists()
        {
            return this.CountMatches() > 0;
        }

        public int CountMatches()
        {
            var combinations = new Combinations<Card>(Cards.ToList(), 3);

            return combinations.Select(c => (new Set(c)).IsValidSet()).Count(x => x);
        }

        public void Deal()
        {
            var cards = this.deck.Deal().Take(3).ToList();

            cards.ForEach(c => this.Cards.Add(c));
        }
    }
}
