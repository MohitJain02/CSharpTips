using Xunit;

namespace GenericMethodUsingImplicitTyping
{
    public class ShortCircuitingOperatorsCheck
    {
        [Fact]
        public void ShortCircutingAndOperator()
        {
            bool a = false;

            bool result1 = a && CheckNames("Sarah");
            bool result = a & CheckNames("Sarah");
            
        }

        private bool CheckNames(string name)
        {
            return name == "Sarah";
        }
    }
}
