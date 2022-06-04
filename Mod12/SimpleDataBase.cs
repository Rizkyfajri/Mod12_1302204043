using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12
{
    public class SimpleDataBase<T>
    {
        List<T>? storedData;//data
        List<DateTime>? inputDates;//tanggal
        public SimpleDataBase()//constructor
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            foreach (var data in storedData)
            {
                Console.WriteLine(data);//output data
            }
            foreach (var data in inputDates)
            {
                Console.WriteLine(data);//output tanggal
            }
        }
    }
}
