using System.Diagnostics;

namespace GenericMethodUsingImplicitTyping
{
    public class DebugWriter
    {
        public void WriterToDebug<T>(T t)
        {
            Debug.WriteLine(t);
        }

        public void Write<T>(T t) where T :IExtensibleDebugger
        {
            Debug.WriteLine(t.DebugInfo);
        }


    }
}
