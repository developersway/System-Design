// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Vending_Machine.DTO;
using Vending_Machine.InMemory;
using Vending_Machine.Interface;
using Vending_Machine.Services;

List<VendorItems> inventoryItems = new Inventory().VendorItems();

UserService userState = new UserService(inventoryItems);

try
{
    userState.SetMachineState(new IdleService(userState));
    IVendingMachineState vendingState = userState.GetMachineState();

    vendingState.StartVendingMachine();
    vendingState = userState.GetMachineState();

    vendingState.EnterMoney(19);
    vendingState = userState.GetMachineState();

    vendingState.EnterItemNumber(1);
    vendingState = userState.GetMachineState();

    vendingState.ItemDelhivery();
}
catch(Exception ex)
{

}


