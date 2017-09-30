using System;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class GenericMethodInNonGenricClass
    {
        [Fact]
        public void UseGenericMethods()
        {
            var debugWriter = new DebugWriter();

            var datetime = DateTime.Now;

            debugWriter.WriterToDebug(datetime);

            var movie = new Movie();

            debugWriter.Write(movie);
        }
    }
}
