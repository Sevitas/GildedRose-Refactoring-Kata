using System.Collections.Generic;
using csharp.Updaters;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    ItemUpdater itemUpdater = ItemCategory.Categorize(item);
                    itemUpdater.UpdateItem(item);
                }
                
                if (item.Quality < 50 &&
                    item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality = item.Quality + 1;

                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }
                }

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.SellIn = item.SellIn - 1;

                    if (item.SellIn < 0)
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
            }
        }
    }
}