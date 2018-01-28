using System;
using System.Diagnostics;

namespace GenericMethodUsingImplicitTyping.DesignPattern
{
    /// <summary>
    /// Best way to implement Singlton pattern
    /// </summary>
    public class SingletonProxy
    {
        private static SingletonProxy instance = new SingletonProxy();

        private SingletonProxy()
        {
            Debug.WriteLine("Single Proxy Instance");
        }

        public static SingletonProxy SingletonInstance
        {
           get
            {
                return instance;
            }
        }

        public static void DoSomething()
        {
            Debug.WriteLine("Do Something");
        }
    }
}
