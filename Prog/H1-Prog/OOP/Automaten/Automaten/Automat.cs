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
            Console.Write($"{item.GetName()}|{item.GetID()}|{nl}");
        }

        private void StockItems(Storage st)
        {
            int rowLengthNumb = -1;
            int rowLengthMax = 2;
            int x = 2, y = 1;
            Console.CursorLeft = x;
            Console.CursorTop = y;

            for (int i = 0; i < items.Count; i++)
            {
                st.AddStorageItem(items[i].GetID().ToString(), items[i]);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                if (rowLengthNumb < rowLengthMax)
                {
                    DrawStorageItem(items[i]);
                    rowLengthNumb++;
                }
                else
                {
                    Draw.DrawFloor(x, Console.CursorTop + 1, GetLongestRow(items, 4) + (3 * 2)+1, '-');
                    //Console.CursorTop;
                    Console.CursorLeft = x;
                    DrawStorageItem(items[i]);
                    rowLengthNumb = 0;
                }
            }
        }

        private int GetLongestRow(List<Item> itemList, int itemsOnRow)
        {
            int longest = 0;
            int itemNumb = 0;
            int calc = 0;

            for (int i = 0; i < itemList.Count; i++)
            {
                itemNumb++;
                calc += itemList[i].GetName().Length;
                if (itemNumb >= itemsOnRow)
                {
                    if (longest < calc)
                        longest = calc;
                    calc = 0;
                    itemNumb = 0;
                }
            }

            return longest;
        }

        public void MachineUX()
        {
            Console.SetCursorPosition(2, 22);
            int input = Interact.Input();
        }

        public void SetupAutomat(Storage storage)
        {
            ItemSetup();
            Draw.DrawBox(0, 0, GetLongestRow(items, 4) + (3 * 3) + 20, '#', 20, '|');
            StockItems(storage);
            MachineUX();
        }
    }
}
