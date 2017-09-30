using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
   public class DelayTask
    {
        [Fact]

        public void DelayATask()
        {
            Task.Delay(1000).GetAwaiter().OnCompleted(() => Debug.WriteLine("a"));

            Task.Delay(2000).GetAwaiter().OnCompleted(() => Debug.WriteLine("b"));

            Task.Delay(5000).GetAwaiter().OnCompleted(() => Debug.WriteLine("b"));


            Thread.Sleep(10000);
        }
    }
}
