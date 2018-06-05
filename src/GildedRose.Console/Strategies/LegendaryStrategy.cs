using System;

namespace GildedRose.Console.Strategies
{
    public class LegendaryStrategy : IStrategy
    {
        public void Update(Item item)
        {
            if (!item.IsLegendary())
            {
                throw new ArgumentException("Strategy reserved for Sulfuras");
            }

            // legendary items never change
        }
    }
}