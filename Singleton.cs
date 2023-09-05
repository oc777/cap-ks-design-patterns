using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance;
        private static int TotalInstances;

        private Singleton()
        {
            Console.WriteLine("-- Private constructor is called.");
            Console.WriteLine("-- Exit now from private constructor.");
        }

        static Singleton()
        {
            Console.WriteLine("- Static constructor is called.");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"-Singelton instance is created. Number of instances: {TotalInstances}");
            Console.WriteLine("- Exit from static constructor.");

        }

        //public static Singleton GetInstance
        //{
        //    get { return Instance; }
        //}

        public static Singleton GetInstance => Instance;

        public static int MyInt = 25;
    }
}
