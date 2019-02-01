using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermPOS
{
    class PharmView
    {
        DrugType DrugType;
        public PharmView()
        {

        }

        // GREETING CUSTOMER
        public void GreetingView()
        {
            Console.WriteLine("Welcome to the Pharmicutical Database, for all your pharamicutical needs.");
        }

        // PRINTING DRUG TYPES
        public string DrugTypeList()
        {
            List<string> DrugTypes = new List<string>() { "Stimulant", "Depressant", "Steroids" };
            int count = 1;
            foreach (string d in DrugTypes)
            {
                Console.WriteLine($"{count}: {d}");
                count++;
            }
            return Input();
        }

        // PRINTING DRUG NAMES
        public string DrugNameList(List<DrugType> Drugs)
        {
            Console.WriteLine($"{Drugs.DrugName}");
            return Input();
        }

        // PRINTING OPTION FOR BOTTLE SIZE
        public string BottleSize()
        {
            Console.WriteLine("Select a bottle size");
            Console.WriteLine("Small (30)");
            Console.WriteLine("Medium (60)");
            Console.WriteLine("Large (90)");
            return Input();
        }

        public string Input()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
