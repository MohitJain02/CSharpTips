using System.Diagnostics;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class ComplierInferredGenricMethodType
    {
        [Fact]
        public void WriteDebugOutputToConsole()
        {
            string name = "Mohit";
            int empid = 3146563;

            Debug.WriteLine("Explicitly specifying the type");
            DebugToConsole<string>(name); // Explicity specifying the type
            DebugToConsole<int>(empid); // Explicity specifying the type

            Debug.WriteLine("Implicity inferred the type y compiler");
            DebugToConsole(name);
            DebugToConsole(empid);


        }

        void DebugToConsole<T>(T obj)
        {
            Debug.WriteLine(obj);
        }

        void DebugToConsole(string name)
        {
            Debug.WriteLine("This is overriden by non generic method from generic one" + name);
        }
    }
}
