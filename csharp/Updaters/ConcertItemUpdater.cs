using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public class ConcertItemUpdater : ItemUpdater
    {
        private const int tenDaysToConcert = 10;
        private const int fiveDaysToConcert = 5;

        public override void UpdateItem(Item item)
        {
            IncrementQuality(item);

            if (item.SellIn <= tenDaysToConcert)
                IncrementQuality(item);

            if (item.SellIn <= fiveDaysToConcert)
                IncrementQuality(item);
        }
    }
}
