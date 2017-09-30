using System;

namespace TipsAndTraps
{
    public class ConcreteClassWithStaticConstructorException
    {

        static ConcreteClassWithStaticConstructorException()
        {
            throw new NotFiniteNumberException();
        }

        public ConcreteClassWithStaticConstructorException()
        {
            throw new NotFiniteNumberException();
        }

        public static string Test()
        {
            return "Mohit";
        }
    }
}
