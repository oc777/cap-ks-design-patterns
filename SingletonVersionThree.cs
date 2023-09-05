using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonVersionThree
    {
        /*
         * Use ing volatile to ensure
         * that assig´nment to the instance variable finishes
         * before it is accessed
         */

        private static volatile SingletonVersionThree Instance;
        private static object lockObject = new object();

        private SingletonVersionThree() { }
        public static SingletonVersionThree GetInstance
        {
            get
            {
                lock (lockObject)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonVersionThree();
                    }
                }
                return Instance;
            }
        }
    }
}
