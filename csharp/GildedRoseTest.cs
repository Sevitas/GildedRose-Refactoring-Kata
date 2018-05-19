using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        #region Basic Tests        
        [Test]
        [TestCase(22, 5, 21, 4)]
        [TestCase(20, 1, 19, 0)]
        public void UpdateQuality_QualityDecrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality},
                new Item {Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 0, 18, -1)]
        [TestCase(20, -1, 18, -2)]
        public void UpdateQuality_SellInPassed_QualityDecreaseTwice_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality},
                new Item {Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(2, 0, 0, -1)]
        [TestCase(1, -1, 0, -2)]
        public void UpdateQuality_SellInPassed_MinQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality},
                new Item {Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(0, 5, 0, 4)]
        [TestCase(0, -2, 0, -3)]
        public void UpdateQuality_NegativeQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality},
                new Item {Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }
        #endregion

        #region Aged Brie Tests            
        [Test]
        [TestCase(49, 5, 50, 4)]
        [TestCase(50, 5, 50, 4)]
        public void UpdateQuality_AgedBrieMaxQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(19, 5, 20, 4)]
        [TestCase(19, 2, 20, 1)]
        [TestCase(19, 1, 20, 0)]
        public void UpdateQuality_AgedBrieQualityIncrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]        
        [TestCase(19, 0, 21, -1)]
        [TestCase(19, -1, 21, -2)]
        public void UpdateQuality_AgedBrieQualityIncrease_PassedSellInn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(49, -1, 50, -2)]
        public void UpdateQuality_AgedBrieMaxQuality_PassedSellIn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }
        #endregion

        #region Concert Tests
        [Test]
        [TestCase(49, 5, 50, 4)]
        [TestCase(50, 5, 50, 4)]
        public void UpdateQuality_ConcertMaxQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(49, 8, 50, 7)]
        [TestCase(49, 3, 50, 2)]
        public void UpdateQuality_ConcertMaxQuality_PassedEdgeValues_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality}
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(40, 25, 41, 24)]
        [TestCase(20, 12, 21, 11)]
        [TestCase(20, 11, 21, 10)]
        public void UpdateQuality_Concert_MoreThan10Days_QualityIncrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 10, 22, 9)]
        [TestCase(20, 9, 22, 8)]
        [TestCase(20, 6, 22, 5)]
        public void UpdateQuality_Concert_10_To_5_Days_QualityIncrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 5, 23, 4)]
        [TestCase(20, 3, 23, 2)]
        [TestCase(20, 1, 23, 0)]
        public void UpdateQuality_Concert_5_To_0_Days_QualityIncrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 0, 0, -1)]
        public void UpdateQuality_After_Concert_QualityDecrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, -1, 0, -2)]
        [TestCase(0, -1, 0, -2)]
        public void UpdateQuality_After_Concert_QualityDecrease_PassedSellIn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }
        #endregion

        #region Legend tests            
        [Test]
        [TestCase(20, 10, 20, 10)]
        [TestCase(20, 0, 20, 0)]
        [TestCase(20, -1, 20, -1)]
        public void UpdateQuality_LegendQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 0, 20, 0)]
        [TestCase(20, -1, 20, -1)]
        [TestCase(20, -10, 20, -10)]
        public void UpdateQuality_LegendQuality_PassedSellIn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }
        #endregion

        #region Conjured Tests
        [Test]
        [TestCase(20, 10, 18, 9)]
        [TestCase(20, 2, 18, 1)]
        public void UpdateQuality_ConjuredQualityDecrease_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Conjured Mana Cake",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(20, 1, 16, 0)]
        [TestCase(20, 0, 16, -1)]
        [TestCase(20, -1, 16, -2)]
        public void UpdateQuality_ConjuredQualityDecrease_PassedSellIn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Conjured Mana Cake",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(4, 1, 0, 0)]
        [TestCase(3, 1, 0, 0)]
        [TestCase(2, 0, 0, -1)]
        [TestCase(1, -1, 0, -2)]
        public void UpdateQuality_ConjuredQualityDecrease_MinQuality_PassedSellIn_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Conjured Mana Cake",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }

        [Test]
        [TestCase(2, 10, 0, 9)]
        [TestCase(1, 10, 0, 9)]
        public void UpdateQuality_ConjuredQualityDecrease_MinQuality_Test(int quality, int sellIn, int expectedQuality, int expectedSellIn)
        {
            IList<Item> Items = new List<Item>
            {
                new Item
                {
                    Name = "Conjured Mana Cake",
                    SellIn = sellIn,
                    Quality = quality
                }
            };

            assertValues(expectedQuality, expectedSellIn, Items);
        }
        #endregion

        private void assertValues(int expectedQuality, int expectedSellIn, IList<Item> items)
        {
            GildedRose gildedRose = new GildedRose(items);
            gildedRose.UpdateQuality();

            foreach (Item item in items)
            {
                Assert.AreEqual(expectedQuality, item.Quality);
                Assert.AreEqual(expectedSellIn, item.SellIn);
            }
        }
    }
}
