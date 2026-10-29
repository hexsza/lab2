using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static int ToMultiplicate(int x, int n = 2)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }
        static double ToMultiplicate(double x, int n = 2)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }
        static string ToMultiplicate(string x, int n = 2)
        {
            string sum = "";
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToMultiplicate(7));       
            Console.WriteLine(ToMultiplicate(2.7));    
            Console.WriteLine(ToMultiplicate("la"));   

            Console.WriteLine(ToMultiplicate(7,3));    
            Console.WriteLine(ToMultiplicate(2.7, 3));  
            Console.WriteLine(ToMultiplicate("la", 3)); 

        }
    }
}
