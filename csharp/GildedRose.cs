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
                ItemUpdater itemUpdater = ItemCategory.Categorize(item);
                itemUpdater.UpdateItem(item);

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