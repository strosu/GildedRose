namespace GildedRose.Console.Strategies
{
    public class BackstageStrategy : IStrategy
    {
        public void Update(Item item)
        {
            item.DecreaseSellDate();

            if (item.IsSellInZero())
            {
                item.SetQualityToZero();
                return;
            }

            if (item.IsSellInMoreThan10())
            {
                item.IncreaseQualityBy(2);
                return;
            }

            if (item.IsSellInBetween0And5())
            {
                item.IncreaseQualityBy(3);
            }
        }
    }

}