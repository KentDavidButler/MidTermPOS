using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermPOS
{
    class StimulantsDB
    {
        public List<DrugType> DrugName = new List<DrugType>();

        public StimulantsDB()
        {
            DrugName.Add(new DrugType("Adderall", 5.44,""));
            DrugName.Add(new DrugType("Ritalin"), 3.45, "");
            DrugName.Add(new DrugType("Concerta", 2.56, ""));
            DrugName.Add(new DrugType("Focalin",1.45, ""));
        }
    }
}
