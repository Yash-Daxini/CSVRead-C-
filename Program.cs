using System;

namespace Billing_Engine // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVData<Customer> data1 = CSVReader<Customer>.LoadDataFromCsv(@"C:\Users\admin\Desktop\Problem-Tark\Customer.csv");
            List<Customer> dataList1 = data1.DataList;

            foreach (var item in dataList1)
            {
                Console.WriteLine(item.CustomerName);
            }
        }
    }
}