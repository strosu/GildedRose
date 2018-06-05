namespace GildedRose.Console.Strategies
{
    public class AgedBrieStrategy : IStrategy
    {
        public void Update(Item item)
        {
            item.IncreaseQualityBy(1);
            item.DecreaseSellDate();
        }
    }

}