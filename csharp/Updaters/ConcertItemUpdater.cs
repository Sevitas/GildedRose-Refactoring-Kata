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
        private const int zeroQuality = 0;

        public override void UpdateItem(Item item)
        {
            IncrementQuality(item);

            if (item.SellIn <= tenDaysToConcert)
                IncrementQuality(item);

            if (item.SellIn <= fiveDaysToConcert)
                IncrementQuality(item);

            DecrementSellIn(item);

            if (PassedSellInValue(item))
                item.Quality = zeroQuality;
        }

        protected override Boolean PassedSellInValue(Item item)
        {
            return item.SellIn < PassedSellInValueConst;
        }
    }
}
