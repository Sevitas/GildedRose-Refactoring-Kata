using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public abstract class ItemUpdater
    {
        private const int maxQuality = 50;
        private const int minQuality = 0;
        protected const int PassedSellInValueConst = 0;

        public virtual void UpdateItem(Item item) { }

        protected void IncrementQuality(Item item)
        {
            if (maxQuality > item.Quality)
                item.Quality++;
        }

        protected void DecrementQuality(Item item)
        {
            if (minQuality < item.Quality)
                item.Quality--;
        }

        protected void DecrementSellIn(Item item)
        {
            item.SellIn--;
        }

        protected virtual Boolean PassedSellInValue(Item item)
        {
            return item.SellIn <= PassedSellInValueConst;
        }        
    }
}
