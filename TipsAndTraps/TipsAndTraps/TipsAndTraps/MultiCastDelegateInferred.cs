using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndTraps
{
    public delegate int CalculatorDelegate(int a, int b);

    public delegate void DelegateWithInt(int percentage);
    public class MultiCastDelegateInferred
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add Called");

            return a + b;
        }

        public int Multiply (int a , int  b)
        {
            Console.WriteLine("Multiply Called");
            return a * b;

        }

        public void WriteToConsoleWithInt(int percentage)
        {
            Console.WriteLine(percentage);
        }

        public void WriteToConsoleWithMessage(int percentage)
        {
            Console.WriteLine("Console with the message" + percentage);
        }

        public int DelegateOutput()
        {
            var multicastDelegate = new CalculatorDelegate(Multiply);

            multicastDelegate += Add;

            return multicastDelegate(10, 10);

        }

        public void CheckEqualityOfDelagates()
        {
            DelegateWithInt a = WriteToConsoleWithInt;

            DelegateWithInt b = WriteToConsoleWithMessage;

            DelegateWithInt c = WriteToConsoleWithInt;

            bool isEqaulAAndB = a == b;
            bool isEqualBAndC = b == c;
            bool isEqualAAndC = a == c;

            Console.WriteLine(isEqaulAAndB);
            Console.WriteLine(isEqualAAndC);
            Console.WriteLine(isEqualBAndC);

        }

    }
}
