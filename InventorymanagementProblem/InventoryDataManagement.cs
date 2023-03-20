using Newtonsoft.Json;
using objectOrientedProgram.InventoryDataManagementProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgram.InventorymanagementProblem
{
    public class InventoryDataManagement
    {
        List<InventoryData> riceList;
        List<InventoryData> wheatList;
        List<InventoryData> pulsesList;

        public void readJsonFile(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            display(riceList);
            wheatList = result.WheatList;
            display(wheatList);
            pulsesList = result.PulsesList;
            display(pulsesList);
        }
        public void display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.PricePerKg * inventory.Weight);
            }
        }
        public void AddInventory(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            wheatList = result.WheatList;
            pulsesList = result.PulsesList;
            Console.WriteLine("Enter the name of list to add inventory");
            String name = Console.ReadLine();
            InventoryData inventoryData = new InventoryData();
            Console.WriteLine("Enter inventory details");
            inventoryData.Name = Console.ReadLine();
            inventoryData.Weight = Convert.ToDouble(Console.ReadLine());
            inventoryData.PricePerKg= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(inventoryData.ToString());
            if (name.Equals("rice"))
            {
                riceList.Add(inventoryData);
            }
            if (name.Equals("wheat"))
            {
                wheatList.Add(inventoryData);
            }
            if (name.Equals("pulses"))
            {
                pulsesList.Add(inventoryData);
            }
            display(riceList);
            display(wheatList);
            display(pulsesList);
        }
        public void EditInventory(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            wheatList = result.WheatList;
            pulsesList = result.PulsesList;
            Console.WriteLine("Enter the list which you want to edit");
            String name = Console.ReadLine();
            if (name.ToLower().Equals("rice"))
            {
                Console.WriteLine("Enter name of rice you want to edit");
                String riceName = Console.ReadLine();
                foreach(var ele in riceList)
                {
                    if (ele.Name.Equals(riceName))
                    {
                        Console.WriteLine("Enter inventory details");
                        ele.Name = Console.ReadLine();
                        ele.Weight = Convert.ToDouble(Console.ReadLine());
                        ele.PricePerKg= Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            if (name.ToLower().Equals("pulses"))
            {
                Console.WriteLine("Enter name of rice you want to edit");
                String pulsesName = Console.ReadLine();
                foreach (var ele in pulsesList)
                {
                    if (ele.Name.Equals(pulsesName))
                    {
                        Console.WriteLine("Enter inventory details");
                        ele.Name = Console.ReadLine();
                        ele.Weight = Convert.ToDouble(Console.ReadLine());
                        ele.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            if (name.ToLower().Equals("wheat"))
            {
                Console.WriteLine("Enter name of rice you want to edit");
                String wheatName = Console.ReadLine();
                foreach (var ele in wheatList)
                {
                    if (ele.Name.Equals(wheatName))
                    {
                        Console.WriteLine("Enter inventory details");
                        ele.Name = Console.ReadLine();
                        ele.Weight = Convert.ToDouble(Console.ReadLine());
                        ele.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            display(riceList);
            display(wheatList);
            display(pulsesList);
        }
    }
}
