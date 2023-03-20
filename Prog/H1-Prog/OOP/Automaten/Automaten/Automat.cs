using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Automat
    {
        int[] rID = { 1, 2, 3, 4};
        char[] prefix = { 'a', 'b', 'c', 'd'};

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
            items.Clear();
            foreach (var item in items) 
            {

            }
        }

        public void SetupAutomat(Storage storage)
        {

        }
    }
}
