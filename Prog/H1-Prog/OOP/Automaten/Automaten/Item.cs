using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Item
    {
        private int? itemId;
        private string itemName;
        private double itemPrice;
        private byte itemAmount;
        private byte maxAmount;
        private bool isEmpty; //Maybe remove

        public Item(int? itemId, string itemName, double itemPrice, byte itemAmount, byte maxAmount)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemAmount = itemAmount;
            this.maxAmount = maxAmount;
        }

        /// <summary>
        /// Checks the amount left in of the item at row space
        /// </summary>
        /// <returns>String value : Item Amount</returns>
        public int GetAmount()
        {
            return itemAmount;
        }
        public string GetName()
        {
            return itemName;
        }
        private bool CheckAmount()
        {
            return itemAmount > 0;
        }

        public void RemoveItem()
        {
            if (CheckAmount())
                itemAmount--;
        }
        public void RestockItem()
        {
            itemAmount = maxAmount;
            Console.WriteLine($"{itemName} is now stocked and have {itemAmount} in stock");
        }

    }
}
