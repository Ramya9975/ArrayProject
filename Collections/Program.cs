using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> list = new List<Object>();
            list.Add(98);
            list.Add(100);
            list.Add(36);
            list.Add("Ramya");
            list.Add("Ram");
            list.Add("Srini");
            List<int> filteredList = new List<int>(); 
            filteredList = list.OfType<int>().ToList();
            foreach(int item in filteredList) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
