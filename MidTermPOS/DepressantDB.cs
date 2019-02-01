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
            DrugName.Add(new DrugType("SleepEZ"));
            DrugName.Add(new DrugType("Xanax"));
            DrugName.Add(new DrugType("Klonopin"));
            DrugName.Add(new DrugType("Valium"));
        }
    }
}
