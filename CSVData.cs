using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Engine
{
    internal class CSVData<T>
    {
        public List<T> DataList { get; set; } = new List<T>();
    }
}
