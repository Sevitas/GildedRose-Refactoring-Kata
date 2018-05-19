using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Updaters
{
    public abstract class ItemUpdater
    {
        protected const int MaxQuality = 50;
        protected const int MinQuality = 0;
        protected const int PassedSellInValue = 0;

        public virtual void UpdateItem(Item item) { }

        protected void IncrementQuality(Item item)
        {
            if (MaxQuality > item.Quality)
                item.Quality++;
        }

        protected void DecrementQuality(Item item)
        {
            if (MinQuality < item.Quality)
                item.Quality--;
        }

        protected void DecrementSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}
