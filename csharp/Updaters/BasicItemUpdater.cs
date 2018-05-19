using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public class BasicItemUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            DecrementQuality(item);

            if (item.SellIn <= PassedSellInValue)
                DecrementQuality(item);

            DecrementSellIn(item);
        }
    }
}
