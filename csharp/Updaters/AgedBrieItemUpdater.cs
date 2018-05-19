﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public class AgedBrieItemUpdater : ItemUpdater
    {
        public override void UpdateItem(Item item)
        {
            IncrementQuality(item);

            if (item.SellIn <= PassedSellInValue)
                IncrementQuality(item);

            DecrementSellIn(item);
        }
    }
}
