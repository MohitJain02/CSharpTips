using System.Threading.Tasks;
using Xunit;

namespace GenericMethodUsingImplicitTyping.DesignPattern
{
    public class SingletonClient
    {
        ////[Fact]
        ////public async Task<int> UseSingleton()
        ////{

        ////    // GetStringAsync returns a Task<string>. That means that when you await the 
        ////    // task you'll get a string (urlContents).
        ////    Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

        ////    // You can do work here that doesn't rely on the string from GetStringAsync.
        ////    DoIndependentWork();

        ////    // The await operator suspends AccessTheWebAsync. 
        ////    //  - AccessTheWebAsync can't continue until getStringTask is complete. 
        ////    //  - Meanwhile, control returns to the caller of AccessTheWebAsync. 
        ////    //  - Control resumes here when getStringTask is complete.  
        ////    //  - The await operator then retrieves the string result from getStringTask. 
        ////    string urlContents = await getStringTask;

        ////    // The return statement specifies an integer result. 
        ////    // Any methods that are awaiting AccessTheWebAsync retrieve the length value. 
        ////    return Task.FromResult(urlContents.Length).Result;
        ////}

        ////SingletonProxy.DoSomething();

        ////Debug.WriteLine("Singleton Test");
        ////var instance1 = SingletonProxy.SingletonInstance;

        ////var instance2 = SingletonProxy.SingletonInstance;

        ////instance1.Equals(instance2);
    }
}
