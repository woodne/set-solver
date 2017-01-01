using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SetFinderLib;

namespace SetFinderLibTest
{
    [TestClass]
    public class TableTests
    {
        private Table table;

        [TestInitialize]
        public void SetUp()
        {
            this.table = new Table();
        }

        [TestMethod]
        public void TableShouldNotFindMatches()
        {
            table.Cards = new HashSet<Card>
            {
                new Card(Shading.Solid, Symbol.Diamond, Color.Purple, Number.One),
                new Card(Shading.Open, Symbol.Oval, Color.Red, Number.One),
                new Card(Shading.Solid, Symbol.Squiggle, Color.Purple, Number.One),

                new Card(Shading.Open, Symbol.Oval, Color.Green, Number.One),
                new Card(Shading.Striped, Symbol.Diamond, Color.Red, Number.Two),
                new Card(Shading.Striped, Symbol.Oval, Color.Red, Number.One),

                new Card(Shading.Open, Symbol.Diamond, Color.Purple, Number.Three),
                new Card(Shading.Open, Symbol.Squiggle, Color.Purple, Number.Two),
                new Card(Shading.Solid, Symbol.Diamond, Color.Red, Number.Two),

                new Card(Shading.Striped, Symbol.Diamond, Color.Purple, Number.Three),
                new Card(Shading.Striped, Symbol.Diamond, Color.Green, Number.Three),
                new Card(Shading.Open, Symbol.Squiggle, Color.Green, Number.Three),

                new Card(Shading.Striped, Symbol.Oval, Color.Red, Number.Three),
                new Card(Shading.Solid, Symbol.Oval, Color.Purple, Number.Three),
                new Card(Shading.Open, Symbol.Oval, Color.Purple, Number.Three)
            };

            var result = table.MatchExists();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TableShouldFindMatches()
        {
            table.Cards = new HashSet<Card>
            {
                new Card(Shading.Solid, Symbol.Diamond, Color.Purple, Number.One),
                new Card(Shading.Open, Symbol.Oval, Color.Red, Number.One),
                new Card(Shading.Solid, Symbol.Squiggle, Color.Purple, Number.One),

                new Card(Shading.Open, Symbol.Oval, Color.Green, Number.One),
                new Card(Shading.Striped, Symbol.Diamond, Color.Red, Number.Two),
                new Card(Shading.Striped, Symbol.Oval, Color.Red, Number.One),

                new Card(Shading.Open, Symbol.Diamond, Color.Purple, Number.Three),
                new Card(Shading.Open, Symbol.Squiggle, Color.Purple, Number.Two),
                new Card(Shading.Solid, Symbol.Diamond, Color.Red, Number.Two),

                new Card(Shading.Striped, Symbol.Diamond, Color.Purple, Number.Three),
                new Card(Shading.Striped, Symbol.Diamond, Color.Green, Number.Three),
                new Card(Shading.Open, Symbol.Squiggle, Color.Green, Number.Three),

                new Card(Shading.Striped, Symbol.Oval, Color.Purple, Number.Three),
                new Card(Shading.Solid, Symbol.Oval, Color.Purple, Number.Three),
                new Card(Shading.Open, Symbol.Oval, Color.Purple, Number.Three)
            };

            var result = table.MatchExists();

            Assert.IsTrue(result);
        }
    }
}
