using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DTO;
using Vending_Machine.Interface;

namespace Vending_Machine.Services
{
    public class DisperseItemService : IVendingMachineState
    {
        UserService userState;

        public DisperseItemService(UserService _userState)
        {
            this.userState = _userState;
        }

        public void ItemDelhivery()
        {
            VendorItems item = this.userState.items.Find(item => item.ItemNumber == this.userState.itemNumber);

            Console.WriteLine(item.ItemName + " has been delivered. Please collect it");

            if (this.userState.extraMoney > 0)
                Console.WriteLine("Please collect the change " + this.userState.extraMoney);

            this.userState.SetMachineState(new IdleService(this.userState));
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void EnterItemNumber(int index)
        {
            throw new NotImplementedException();
        }

        public void EnterMoney(int amount)
        {
            throw new NotImplementedException();
        }

        public void StartVendingMachine()
        {
            throw new NotImplementedException();
        }

        public bool ValidatePriceWithItem(int index, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
