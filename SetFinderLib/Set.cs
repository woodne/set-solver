using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetFinderLib
{
    public class Set
    {
        private HashSet<Card> set;

        public Set(IEnumerable<Card> cards)
        {
            this.set = new HashSet<Card>(cards);
        }

        public bool IsValidSet()
        {
            var colors = set.Select(c => c.Color).Distinct();
            var numbers = set.Select(c => c.Number).Distinct();
            var shadings = set.Select(c => c.Shading).Distinct();
            var symbols = set.Select(c => c.Symbol).Distinct();

            if (colors.Count() == 2)
            {
                return false;
            }

            if (numbers.Count() == 2)
            {
                return false;
            }

            if (shadings.Count() == 2)
            {
                return false;
            }

            if (symbols.Count() == 2)
            {
                return false;
            }

            return true;
        }
    }
}
