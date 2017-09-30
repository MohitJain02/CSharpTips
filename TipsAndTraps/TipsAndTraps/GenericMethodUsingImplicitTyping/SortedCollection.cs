using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

namespace GenericMethodUsingImplicitTyping
{

    public class StringComparere : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
   public  class SortedCollection
    {
        [Fact]

        public void SortedCollectionTest()
        {
            var set = new SortedSet<int> {1, 2, 3, 1};

            // Add Duplicates and see no exception

        }

        [Fact]
        public void SortedCollection_String()
        {
            var set = new SortedSet<string>(new StringComparere());

            set.Add("Mohit");
            set.Add("Jain");
            set.Add("Sarah");
        }

        [Fact]
        public void SortedCollection_Dictionary()
        {
            var setDic = new SortedDictionary<string,int>();
            setDic.Add("Mohit",24);
            setDic.Add("Sarah", 34);
            setDic.Add("Jain", 44);

            // Duplicate key,value pair and get exception
            setDic.Add("Mohit", 24);


        }

        [Fact]
        public void SortedCollection_List()
        {
            var sortList = new SortedList<string, int>();

            sortList.Add("Mohit",24);
            sortList.Add("Sarah", 34);
            sortList.Add("jain", 44);

            //Duplicate <Key,Value> and exception
            sortList.Add("Mohit", 24);

        }
    }

}
