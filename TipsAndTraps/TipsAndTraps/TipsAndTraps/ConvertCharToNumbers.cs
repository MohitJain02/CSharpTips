using System;

namespace TipsAndTraps
{
    public class ConvertCharToNumbers
    {
        public void TakeAdvantageOfGetNumericFunc()
        {
            char a = '5';

            var charToDouble = char.GetNumericValue(a);

            Console.Write(charToDouble);

        }
    }
}
