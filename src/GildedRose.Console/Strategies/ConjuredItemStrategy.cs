namespace GildedRose.Console.Strategies
{
    public class ConjuredItemStrategy : IStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellDate();
            item.DecreaseQualityBy(2);
        }
    }
}