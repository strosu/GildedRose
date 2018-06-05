namespace GildedRose.Console.Strategies
{
    public class DefaultItemStrategy : IStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellDate();
            item.DecreaseQualityBy(1);
        }
    }

}