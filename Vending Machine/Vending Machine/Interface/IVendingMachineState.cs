using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Services;

namespace Vending_Machine.Interface
{
    public interface IVendingMachineState
    {
        public void StartVendingMachine();
        public void EnterMoney(int amount);
        public void Cancel();
        public void EnterItemNumber(int index);
        public bool ValidatePriceWithItem(int index,  int amount);
        public void ItemDelhivery();


    }
}
