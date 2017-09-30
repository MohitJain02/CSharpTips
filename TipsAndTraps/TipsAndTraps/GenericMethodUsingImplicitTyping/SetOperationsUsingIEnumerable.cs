using System.Linq;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class SetOperationsUsingIEnumerable
    {
        [Fact]
        public void PerformSetOperations()
        {
            int[] firstArray = Enumerable.Range(1, 5).ToArray();
            int[] secondArray = Enumerable.Range(5, 5).ToArray();

            var obj1 = new[] { "Mohit", "Jain", "Hero" };
            var obj2 = new[] { "Mohit", "Hero" };


            var exceptOperation = firstArray.Except(secondArray).ToList();
            var exceptOperation_string = obj1.Except(obj2).ToList();
            var unionOperation = firstArray.Union(secondArray).ToList();
            var combineOperation = firstArray.Concat(secondArray).ToList();
            var intersectOperation = firstArray.Intersect(secondArray).ToList();

        }

        [Fact]
        public void ZipOperation()
        {
            var obj1 = new[] {"Mohit","Jain","Hero"};
            var obj2 = new[] { 1,2,3};
            var zipOperation = obj1.Zip(obj2,(name,age) => name + ":" + age).ToList();
        }

        [Fact]
        public void ZipOperation_first()
        {
            var obj1 = new[] { "Mohit", "Jain", "Hero" };
            var obj2 = new[] { 1, 2, 3, 4 };
            var zipOperation = obj1.Zip(obj2, (name, age) => name + ":" + age).ToList();
        }




    }
}
