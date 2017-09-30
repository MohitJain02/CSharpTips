using System;
using System.Diagnostics;

namespace TipsAndTraps
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //MultiCast delegate sample

                var multicastDelegate = new MultiCastDelegateInferred();

                Console.WriteLine(multicastDelegate.DelegateOutput());



            }
            {
                //hiding the Interface implemetation

                var someImplemetation = new HidingInterfaceImplemetation();
                someImplemetation.Method1(); // Implicit Implementation


                //Explicit Implemetation

                var newObj = (SomeInterface) someImplemetation;

                newObj.Method2();


            }

            {
                //Using Reserve keyowrd as Variable name
                UsingReserveKeywordAsVariableName varaibleName = new UsingReserveKeywordAsVariableName();
                Console.WriteLine(varaibleName.UsingNamespaceKeyword());

            }

            {
                //Concrete Class with the exception In static constructor becomes unusable through out the application

                try
                {
                    var name = ConcreteClassWithStaticConstructorException.Test();
                    Console.Write(name);
                }
                catch (Exception)
                {

                   Debug.WriteLine("Exception thrown by the static constructor");
                }

                var instance = new ConcreteClassWithStaticConstructorException();
                Debug.WriteLine(instance);

            }
            Console.ReadLine();
        }
    }
}
