using System.Diagnostics;
using System.Threading;

namespace GenericMethodUsingImplicitTyping
{
   public class Report
    {
        public Report()
        {
            Debug.WriteLine("Accessign the Default ctor***************");

            // Expensive object creation activity
            Thread.Sleep(1000);
                
        }

        public Report(string reportName)
        {
            Debug.WriteLine("Accessign the Default ctor***************" + reportName);

            // Expensive object creation activity
            Thread.Sleep(1000);

        }
        public string ReportName { get; set; }

        public void DoSomething()
        {
            Debug.WriteLine("Do something");
        }


    }
}
