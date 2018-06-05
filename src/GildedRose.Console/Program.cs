
using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {

        public const string AgedBried = "Aged Brie";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        public const string Conjured = "Conjured";

        IList<Item> Items;

        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");
            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                    new Item {Name = AgedBried, SellIn = 2, Quality = 0},
                    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                    new Item {Name = Sulfuras, SellIn = 0, Quality = 80},
                    new Item
                    {
                        Name = BackstagePass,
                        SellIn = 15,
                        Quality = 20
                    },
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            app.UpdateQuality();

            System.Console.ReadKey();
        }

        private void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var itemWrapper = ItemWrapperFactory.BuildItemWrapper(item);
                itemWrapper.Update();
            }
        }


        //static void Main2(string[] args)
        //{
        //    System.Console.WriteLine("OMGHAI!");

        //    var app = new Program()
        //    {
        //        Items = new List<Item>
        //                                  {
        //                                      new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
        //                                      new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
        //                                      new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
        //                                      new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
        //                                      new Item
        //                                          {
        //                                              Name = "Backstage passes to a TAFKAL80ETC concert",
        //                                              SellIn = 15,
        //                                              Quality = 20
        //                                          },
        //                                      new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        //                                  }

        //    };

        //    app.UpdateQuality2();

        //    System.Console.ReadKey();

        //}

        //public void UpdateQuality2()
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //        {
        //            if (Items[i].Quality > 0)
        //            {
        //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                {
        //                    Items[i].Quality = Items[i].Quality - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;

        //                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].SellIn < 11)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellIn < 6)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //        {
        //            Items[i].SellIn = Items[i].SellIn - 1;
        //        }

        //        if (Items[i].SellIn < 0)
        //        {
        //            if (Items[i].Name != "Aged Brie")
        //            {
        //                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].Quality > 0)
        //                    {
        //                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                        {
        //                            Items[i].Quality = Items[i].Quality - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Quality < 50)
        //                {
        //                    Items[i].Quality = Items[i].Quality + 1;
        //                }
        //            }
        //        }
        //    }
        //}

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}