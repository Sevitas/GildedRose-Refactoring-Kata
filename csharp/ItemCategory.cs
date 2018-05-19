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
            return new BasicItemUpdater();
        }
    }
}
