using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermPOS
{
    class DepressantDB
    {
        List<DrugType> DrugName = new List<DrugType>();

        public DepressantDB()
        {
            DrugName.Add(new DrugType("SleepEZ", 2.34, ""));
            DrugName.Add(new DrugType("Xanax", 4.54, ""));
            DrugName.Add(new DrugType("Klonopin", 9.23, ""));
            DrugName.Add(new DrugType("Valium", 8.76, ""));
        }
    }
}
