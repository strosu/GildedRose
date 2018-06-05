using GildedRose.Console.Strategies;

namespace GildedRose.Console
{
    public static class ItemWrapperFactory
    {
        public static ItemWrapper BuildItemWrapper(Item item)
        {
            if (item.IsLegendary())
            {
                return new ItemWrapper(item, new LegendaryStrategy());
            }

            if (item.IsBrie())
            {
                return new ItemWrapper(item, new AgedBrieStrategy());
            }

            if (item.IsBackStagePass())
            {
                return new ItemWrapper(item, new BackstageStrategy());
            }

            if (item.IsConjured())
            {
                return new ItemWrapper(item, new ConjuredItemStrategy());
            }

            return new ItemWrapper(item, new DefaultItemStrategy());
        }
    }
}