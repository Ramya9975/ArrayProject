using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter the array value:");

            for(int i=0; i<size; i++) 
            {
                Console.Write($"Value{i + 1}:");
                array[i] = int.Parse(Console.ReadLine());

            }
            Dictionary<int,int> dic = new Dictionary<int,int>();
            foreach(int num in array) 
            {
                if(dic.ContainsKey(num)) 
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);

                }
            }
            Console.WriteLine("The number and the frequency are:");
            foreach(KeyValuePair<int,int> pair in dic) 
            {
                Console.WriteLine($"Number {pair.Key} appears {pair.Value}times");
            }
            Console.ReadLine();

        }
    }
}
