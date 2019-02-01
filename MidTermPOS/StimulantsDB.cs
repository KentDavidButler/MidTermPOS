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
            DrugName.Add(new DrugType("Adderall"));
            DrugName.Add(new DrugType("Ritalin"));
            DrugName.Add(new DrugType("Concerta"));
            DrugName.Add(new DrugType("Focalin"));
        }
    }
}
