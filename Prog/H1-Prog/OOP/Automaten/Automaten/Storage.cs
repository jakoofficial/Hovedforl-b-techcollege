using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Storage
    {
        private Dictionary<string, Item> storageDict = new Dictionary<string, Item>();

        public void AddStorageItem(string uid, Item item)
        {
            foreach (var dictItem in storageDict)
            {
                if (uid == dictItem.Key)
                {
                    Console.WriteLine($"{uid} is already in use");
                    return;
                }
            }
            storageDict.Add(uid, item);
        }
        public void RemoveStorageItem(string uid)
        {
            foreach (var dictItem in storageDict)
            {
                if (uid == dictItem.Key)
                {
                    storageDict.Remove(uid);
                    return;
                }
            }
            Console.WriteLine($"{uid} does not have an item");
        }

    }
}
