using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Automat
    {
        List<Item> items = new List<Item>()
        {
            new Item(null, "Coke", 10, 12, 12),
            new Item(null, "Coke", 10, 12, 12),
            new Item(null, "Coke", 10, 12, 12),
            new Item(null, "Coke", 10, 12, 12),
            new Item(null, "Coke", 10, 12, 12)
        };

        private void ItemSetup()
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].SetID(i + 1);
            }
        }

        private void DrawStorageItem(Item item, string nl = " ")
        {
            Console.Write($"{item.GetID()}:{item.GetName()}{nl}");
        }

        private void StockItems(Storage st)
        {
            int rowLengthNumb = 0;
            int rowLengthMax = 4;
            for (int i = 0; i < items.Count; i++)
            {
                st.AddStorageItem(items[i].GetID().ToString(), items[i]);
                if (rowLengthNumb < rowLengthMax)
                {
                    DrawStorageItem(items[i]);
                    rowLengthNumb++;
                }
                else
                {
                    DrawStorageItem(items[i], "\n");
                    rowLengthNumb = 0;
                }
            }
        }

        public void SetupAutomat(Storage storage)
        {
            ItemSetup();
            StockItems(storage);
        }
    }
}
