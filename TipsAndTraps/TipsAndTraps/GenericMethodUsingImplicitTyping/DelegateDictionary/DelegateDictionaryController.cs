using System;
using System.Collections.Generic;

namespace GenericMethodUsingImplicitTyping.DelegateDictionary
{
    public delegate string Delegate1(int test);
    public delegate string Delegate2(string test);
    public delegate int Delegate3();

    public class DelegateDictionaryController
    {
        private Dictionary<string, Delegate> delegateMapper;
        public DelegateDictionaryController()
        {
            delegateMapper = new Dictionary<string, Delegate>();
        }

        public string Func1(int test)
        {
            return $"This is Func1: {test}";
        }

        public string Func2(string test)
        {
           return $"This is Func2: {test}";
        }

        public int Func3()
        {
            Console.WriteLine("This is Func3");
            return 2;
        }

        public Dictionary<string, Delegate> DelegateMapperFunc()
        {
            delegateMapper.Add("Func1", new Delegate1(Func1));
            delegateMapper.Add("Func2", new Delegate2(Func2));
            delegateMapper.Add("Func3", new Delegate3(Func3));
            return delegateMapper;
        }
    }
}
