using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Interface;

namespace Vending_Machine.Services
{
    public class InsertAmountService : IVendingMachineState
    {

        UserService userState;
        public InsertAmountService(UserService _userState)
        {
            this.userState = _userState;
        }

        public void Cancel()
        {
            this.userState.SetMachineState(new IdleService(this.userState));
        }
        public void EnterMoney(int amount)
        {
            this.userState.amountPaidByUser = amount;
            this.userState.SetMachineState(new ItemService(this.userState));
        }

        public void EnterItemNumber(int index)
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

        public bool ValidatePriceWithItem(int index, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
