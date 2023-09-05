using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Singleton Pattern Demonstration.*********\n");
            //Console.WriteLine("Trying to get a Singleton instance, called firstInstance.");
            //Singleton firstInstance = Singleton.GetInstance;
            //Console.WriteLine("Trying to get a Singleton instance, called secondInstance.");
            //Singleton secondInstance = Singleton.GetInstance;

            //if (firstInstance.Equals(secondInstance))
            //{
            //    Console.WriteLine("The firstInstance and secondInstance are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("Different instances exist.");
            //}
            Console.WriteLine($"The value of MyInt is : {Singleton.MyInt}");
            Console.Read();
        }
    }
}
