namespace GildedRose.Console
{
    public static class ItemExtensions
    {
        private static int GetQualityDecreaseMultiplier(this Item item)
        {
            return item.SellIn == 0 ? 2 : 1;
        }

        public static void DecreaseQualityBy(this Item item, int amount)
        {
            var multiplier = item.GetQualityDecreaseMultiplier();

            if (item.Quality - amount >= 0)
            {
                item.Quality -= amount * multiplier;
            }
            else
            {
                item.Quality = 0;
            }
        }

        public static void IncreaseQualityBy(this Item item, int amount)
        {
            if (item.Quality + amount <= 50)
            {
                item.Quality += amount;
            }
            else
            {
                item.Quality = 50;
            }
        }

        public static void DecreaseSellDate(this Item item)
        {
            if (item.SellIn > 0)
            {
                item.SellIn--;
            }
        }

        public static bool IsLegendary(this Item item)
        {
            return item.Name == Program.Sulfuras;
        }

        public static bool IsBrie(this Item item)
        {
            return item.Name == Program.AgedBried;
        }

        public static bool IsBackStagePass(this Item item)
        {
            return item.Name == Program.BackstagePass;
        }

        public static bool IsConjured(this Item item)
        {
            return item.Name == Program.Conjured;
        }

        public static bool IsSellInZero(this Item item)
        {
            return item.SellIn == 0;
        }

        public static void SetQualityToZero(this Item item)
        {
            item.Quality = 0;
        }

        public static bool IsSellInMoreThan10(this Item item)
        {
            return item.SellIn > 10;
        }

        public static bool IsSellInBetween0And5(this Item item)
        {
            return item.SellIn <= 5 && item.SellIn > 0;
        }
    }
}