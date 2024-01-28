using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Engine
{
    internal class CSVReader<T>
    {
        public static CSVData<T> LoadDataFromCsv(string filePath)
        {
            CSVData<T> csvData = new CSVData<T>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csvData.DataList = csv.GetRecords<T>().ToList();
            }

            return csvData;
        }
    }
}
