using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DTO;

namespace Vending_Machine.InMemory
{
    public class Inventory
    {
        public List<VendorItems> VendorItems()
        {
            List<VendorItems> inventoryItems = new List<VendorItems>();
            inventoryItems.Add(new VendorItems()
            {
                ItemName = "Choclate",
                Price = 10,
                ItemNumber = 1
            });
            inventoryItems.Add(new VendorItems()
            {
                ItemName = "Biscuit",
                Price = 20,
                ItemNumber = 2
            });
            return inventoryItems;
        }
    }
}
