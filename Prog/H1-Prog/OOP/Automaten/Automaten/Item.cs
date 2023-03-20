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

        /// <summary>
        /// The item constructor for when creating a new item
        /// </summary>
        /// <param name="itemId">Int? : item id</param>
        /// <param name="itemName">String : item name</param>
        /// <param name="itemPrice">Double : item price</param>
        /// <param name="itemAmount">byte : current item amount</param>
        /// <param name="maxAmount">byte : max item amount</param>
        public Item(int? itemId, string itemName, double itemPrice, byte itemAmount, byte maxAmount)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemAmount = itemAmount;
            this.maxAmount = maxAmount;
        }

        /// <summary>
        /// Sets a new item id
        /// </summary>
        /// <param name="id">Int : new item id</param>
        public void SetID(int id)
        {
            itemId = id;
        }
        public int? GetID()
        {
            return itemId;
        }

        /// <summary>
        /// Checks the amount left in of the item at row space
        /// </summary>
        /// <returns>String value : Item Amount</returns>
        public int GetAmount()
        {
            return itemAmount;
        }
        /// <summary>
        /// Returns the name of te item
        /// </summary>
        /// <returns>String value : Item Name</returns>
        public string GetName()
        {
            return itemName;
        }

        /// <summary>
        /// Checks if the amount of items is higher than 0
        /// </summary>
        /// <returns>Boolean value : True/False</returns>
        private bool CheckAmount()
        {
            return itemAmount > 0;
        }
        /// <summary>
        /// Removes one from item amount
        /// </summary>
        public void RemoveItem()
        {
            if (CheckAmount())
                itemAmount--;
        }
        /// <summary>
        /// Makes te item amount as the highest it can be
        /// </summary>
        public void RestockItem()
        {
            itemAmount = maxAmount;
            Console.WriteLine($"{itemName} is now stocked and have {itemAmount} in stock");
        }

    }
}
