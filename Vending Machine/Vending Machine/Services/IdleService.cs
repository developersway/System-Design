using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Interface;

namespace Vending_Machine.Services
{
    public class IdleService : IVendingMachineState
    {
        public UserService userState;

        public IdleService(UserService _userState)
        {
            this.userState = _userState;
        }

        public void StartVendingMachine()
        {
            this.userState.SetMachineState(new InsertAmountService(this.userState));
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

        public void ItemDelhivery()
        {
            throw new NotImplementedException();
        }

        public bool ValidatePriceWithItem(int index, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
