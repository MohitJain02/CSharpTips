using System;

namespace TipsAndTraps
{
    internal interface SomeInterface
    {
        void Method1();
        void Method2();
    }
    internal class HidingInterfaceImplemetation : SomeInterface
    {
        public void Method1()
        {
            Console.WriteLine("Implicit Implementation of Method1");
        }

        void SomeInterface.Method2()
        {
            Console.WriteLine("Explicit Implementation of Method2");
        }
    }
}
