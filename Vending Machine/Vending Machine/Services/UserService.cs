using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.DTO;
using Vending_Machine.Interface;

namespace Vending_Machine.Services
{
    public class UserService
    {
        IVendingMachineState currentMachineState;


        public List<VendorItems> items;
        public int amountPaidByUser;
        public int itemNumber;
        public int extraMoney;

        public UserService(List<VendorItems> _items)
        {
            this.items = _items;
            this.amountPaidByUser = 0;
            this.extraMoney = 0;
        }

        public IVendingMachineState GetMachineState()
        {
            return this.currentMachineState ;
        }

        public IVendingMachineState SetMachineState(IVendingMachineState newState)
        {
            this.currentMachineState = newState;
            return newState;
        }


    }
}
