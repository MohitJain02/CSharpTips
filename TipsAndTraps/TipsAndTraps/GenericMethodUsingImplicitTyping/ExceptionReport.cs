using System;
using System.Diagnostics;
using Xunit.Sdk;

namespace GenericMethodUsingImplicitTyping
{
    public class ExceptionReport
    {
        public ExceptionReport()
        {
            Debug.WriteLine("Constructor Called for the ExceptionReport");

            throw new NullException($"Time of the error is {DateTime.Now.ToString()}");

        }

        public void DoSomething()
        {
           //Nothing to implement
        }
    }
}

