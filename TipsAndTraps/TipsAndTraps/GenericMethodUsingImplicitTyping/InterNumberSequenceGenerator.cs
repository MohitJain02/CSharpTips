using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class InterNumberSequenceGenerator
    {
        [Fact]

        public void GenerateEnumerableRange()
        {
            var intergerNumber = Enumerable.Range(1, 10);
            int[] intergerArray = Enumerable.Range(1, 10).ToArray();
            List<int> intergerList = Enumerable.Range(100, 31).ToList();
        }
    }
}
