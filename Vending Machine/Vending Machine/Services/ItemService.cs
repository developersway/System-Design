using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DTO;
using Vending_Machine.Interface;

namespace Vending_Machine.Services
{
    public class ItemService : IVendingMachineState
    {
        UserService userState;

        public ItemService(UserService _userState)
        {
            this.userState = _userState;
        }

        public void Cancel()
        {
            this.userState.SetMachineState(new IdleService(this.userState));
        }

        public void EnterItemNumber(int index)
        {
            this.userState.itemNumber = index;
            if(!ValidatePriceWithItem(index, this.userState.amountPaidByUser))
                this.userState.SetMachineState(new IdleService(this.userState));
            else
                this.userState.SetMachineState(new DisperseItemService(this.userState)); 
        }

        public bool ValidatePriceWithItem(int index, int amount)
        {
            VendorItems item = this.userState.items.Find(item => item.ItemNumber == index);
            if (item == null)
            {
                Console.WriteLine("Item doesnot exists");
                return false;
            }
            if (item.Price > amount)
            {
                Console.WriteLine("The Item is not in the range");
                return false;
            }
            this.userState.extraMoney = amount - item.Price;
            return true;

        }


        public void EnterMoney(int amount)
        {
            throw new NotImplementedException();
        }

        public void ItemDelhivery()
        {
            throw new NotImplementedException();
        }

        public void StartVendingMachine()
        {
            throw new NotImplementedException();
        }

    }
}
