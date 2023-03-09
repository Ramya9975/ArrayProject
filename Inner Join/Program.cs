using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] company = { "TCS", "Cognizant", "Wipro", "NLTD", "Accenture" };
            string[] company1 = { "TCS", "Cognizant", "Deloitte", "Infosys", "CMA" };

            IEnumerable<string> Join = company.Intersect(company1);

            Console.WriteLine("The output for Inner Join:");
            foreach(string name in Join) 
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
