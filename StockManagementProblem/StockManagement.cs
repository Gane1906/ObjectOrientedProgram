using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgram.StockManagementProblem
{
    public class StockManagement
    {
        public void ReadStocJson(String filePath)
        {
            var data = File.ReadAllText(filePath);
            var result=JsonConvert.DeserializeObject<List<StockInvetory>>(data);
            foreach (var stock in result)
            {
                Console.WriteLine(stock.StockName+"\t"+stock.NumOfShares+"\t"+stock.PricePerShare+"\t"+stock.NumOfShares*stock.PricePerShare);
            }
        }
    }
}
