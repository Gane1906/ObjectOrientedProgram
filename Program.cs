using objectOrientedProgram.InventoryDataManagementProblem;
using objectOrientedProgram.InventorymanagementProblem;
using System;
namespace ObjectOrientedProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
            bool flag = true;
            while (flag)
            {
                Console.Write("1.Inventory Data\n2.Inventory data management\n3.Add Inventory\n4.Edit Inventory\n5.Exit\nEnter your option: ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryOperation inventoryOperation=new InventoryOperation();
                        inventoryOperation.readJsonFile(@"E:\Users\Ganesh\Documents\BL Excercise\objectOrientedProgram\InventoryDataManagementProblem\Inventory.json");
                        break;
                    case 2:
                        inventoryDataManagement.readJsonFile(@"E:\Users\Ganesh\Documents\BL Excercise\objectOrientedProgram\InventorymanagementProblem\InventoryDetails.json");
                        break;
                    case 3:
                        inventoryDataManagement.AddInventory(@"E:\Users\Ganesh\Documents\BL Excercise\objectOrientedProgram\InventorymanagementProblem\InventoryDetails.json");
                        break;
                    case 4:
                        inventoryDataManagement.EditInventory(@"E:\Users\Ganesh\Documents\BL Excercise\objectOrientedProgram\InventorymanagementProblem\InventoryDetails.json");
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
            
            
        } 
    }
}