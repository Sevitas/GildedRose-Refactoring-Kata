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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "+5 Dexterity Vest" || Items[i].Name == "Elixir of the Mongoose" ||
                    Items[i].Name == "Aged Brie")
                {
                    ItemUpdater itemUpdater = ItemCategory.Categorize(Items[i]);
                    itemUpdater.UpdateItem(Items[i]);
                }

                
                if (Items[i].Quality < 50 &&
                    Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (Items[i].SellIn < 11)
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }

                    if (Items[i].SellIn < 6)
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }

                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;

                    if (Items[i].SellIn < 0)
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
            }
        }
    }
}