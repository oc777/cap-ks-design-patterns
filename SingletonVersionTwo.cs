using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonVersionTwo
    {
        private static SingletonVersionTwo instance;
        private SingletonVersionTwo() { }
        public static SingletonVersionTwo Instance { 
            get 
            {
                if (instance == null)
                {
                    instance = new SingletonVersionTwo();
                }
                return instance; 
            } 
        } 
    }
}
