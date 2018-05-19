using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public class ConjuredItemUpdater : ItemUpdater
    {
        private const int normalDecreaseValue = 2;
        private const int passedSellInDecreaseValue = 4;

        public override void UpdateItem(Item item)
        {            
            DecrementSellIn(item);
            int number = numberOfQualityDecrease(item);
            for (int i = 0; i < number; i++)
            {
                DecrementQuality(item);
            }
        }

        private int numberOfQualityDecrease(Item item)
        {
            return item.SellIn > PassedSellInValue
                ? Math.Min(item.Quality, normalDecreaseValue)
                : Math.Min(item.Quality, passedSellInDecreaseValue);
        }
    }
}
