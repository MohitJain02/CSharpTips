using System.Diagnostics;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class StructEqualityPerformance
    {

        [Fact]
        public void ReferenceTypeMemeberEquality()
        {
            var obj1 = new StructWithNoOverrideAndNoReferenceType {Value1 = 1, Value2 = 2};
            var obj2 = new StructWithNoOverrideAndNoReferenceType { Value1 = 1, Value2 = 2 };

            var obj3 = new StructWithOverrideAndReferenceType
            {
                Value1 = 1, Value2 = 2, Description = "Mohit"
                    
            };

            var obj4 = new StructWithOverrideAndReferenceType
            {
                Value1 = 1,
                Value2 = 2,
                Description = "Mohit"
            };

            var timeElapsed1 = CalculateEqualPerformance(obj1, obj2);
            var timeElapsed2 = CalculateEqualPerformance(obj3, obj4);

        }

        [Fact]
        public void ReferenceTypeMemeberEquality_Part2()
        {
            var obj1 = new StructWithOverrideAndReferenceType { Value1 = 1, Value2 = 2, Description = "mohit"};
            var obj2 = new StructWithOverrideAndReferenceType { Value1 = 1, Value2 = 2, Description = "mohit" };

            var obj3 = new StructWithNoOverrideAndReferenceType
            {
                Value1 = 1,
                Value2 = 2,
                Description = "Mohit"

            };

            var obj4 = new StructWithNoOverrideAndReferenceType
            {
                Value1 = 1,
                Value2 = 2,
                Description = "Mohit"
            };

            var timeElapsed1 = CalculateEqualPerformance(obj1, obj2);
            var timeElapsed2 = CalculateEqualPerformance(obj3, obj4);

        }

        private long CalculateEqualPerformance(object obj1, object obj2)
        {
            var watch = new Stopwatch();

            watch.Start();
            for (var i = 0; i < 1000000; i++)
            {
                obj1.Equals(obj2);
            }

            watch.Stop();

            return watch.ElapsedMilliseconds;

        }
    }
}
