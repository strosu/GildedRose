using GildedRose.Console.Strategies;

namespace GildedRose.Console
{
    public class ItemWrapper
    {
        private Item Item { get; }
        private IStrategy Strategy { get; }

        public ItemWrapper(Item item, IStrategy strategy)
        {
            Item = item;
            Strategy = strategy;
        }

        public void Update()
        {
            Strategy.Update(Item);
        }
    }

}