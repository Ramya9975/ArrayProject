using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] items = { "Ram", "Ramya", "RekhaKumar", "Sri", "Raju" };
                Array.Sort(items, (a, b) => {
                    int result = a.Length.CompareTo(b.Length);
                    if (result == 0)
                    {
                        result = a.CompareTo(b);
                    }
                    return result;
                }); 
            Console.WriteLine("Sorting items are:");

                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            Console.ReadLine();

            }
        }
    }
    

