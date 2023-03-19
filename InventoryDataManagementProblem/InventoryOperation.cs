using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace objectOrientedProgram.InventoryDataManagementProblem
{
    public class InventoryOperation
    {
        public void readJsonFile(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result=JsonConvert.DeserializeObject<List<InventoryData>>(data);
            foreach(var inventory in result)
            {
                Console.WriteLine(inventory.Name+"\t"+inventory.Weight+"\t"+inventory.PricePerKg+"\t"+inventory.PricePerKg*inventory.Weight);
            }
        }
    }
}
