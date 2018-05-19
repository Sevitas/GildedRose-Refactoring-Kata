using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Updaters;

namespace csharp
{
    public static class ItemCategory
    {
        public static ItemUpdater Categorize(Item item)
        {
            if (item.Name.Contains("Aged Brie"))
                return new AgedBrieItemUpdater();

            if (item.Name.Contains("Sulfuras"))
                return new LegendaryItemUpdater();

            if (item.Name.Contains("Backstage passes"))
            {
                return new ConcertItemUpdater();
            }

            if (item.Name.Contains("Conjured"))
            {
                return new ConjuredItemUpdater();
            }

            return new BasicItemUpdater();
        }
    }
}
