using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> templist = new List<int>();
            templist.Add(15);
            templist.Add(17);
            templist.Add(13);
            templist.Add(24);
            templist.Add(60);
            templist.Add(29);
            templist.Add(98);
            templist.Add(7);

            Console.WriteLine("The member of the list are:");
            foreach (var item in templist)
            {
                Console.WriteLine(item);
            }
            Console.Write("How many records you want to display:");
            int num = Convert.ToInt32(Console.ReadLine());
            templist.Sort();
            templist.Reverse();
            Console.Write("Top records from the list are:");
            foreach (int topnum in templist.Take(num))
            {
                Console.WriteLine(topnum);
            }
            Console.ReadLine();

        }
    }
}

