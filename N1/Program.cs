using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[7];
            int s = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s+=array[i];
                k++;
      
            }
            Console.WriteLine();
            Console.WriteLine(s / k);
            Console.ReadKey();
        }
    }
}
