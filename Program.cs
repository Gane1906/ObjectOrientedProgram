using objectOrientedProgram.InventoryDataManagementProblem;
using System;
namespace ObjectOrientedProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("1.Inventory Data\n2.Exit\nEnter your option: ");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryOperation inventoryOperation=new InventoryOperation();
                        inventoryOperation.readJsonFile(@"E:\Users\Ganesh\Documents\BL Excercise\objectOrientedProgram\InventoryDataManagementProblem\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        } 
    }
}