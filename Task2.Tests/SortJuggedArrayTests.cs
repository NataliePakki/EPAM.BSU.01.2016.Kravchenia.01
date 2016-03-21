using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Task2.Tests{
    [TestFixture]
    public class SortJuggedArrayTests{
        readonly int[][] _array = { new [] { 2, 3, 4 }, new[] { 3, -454, 67, 7 }, new []{1,2,3,0,4} };
        private class ComparerMaxElement : IComparer {
        public int Compare(object a, object b){
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int[] arr1 = (int[])a;
            int[] arr2 = (int[])b;
            return arr1.Max(x => Math.Abs(x)).CompareTo(arr2.Max(x => Math.Abs(x)));
        }
    }
        private class ComparerMaxSumElement : IComparer{
        public int Compare(object a, object b){
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int[] arr1 = (int[])a;
            int[] arr2 = (int[])b;
            return arr1.Sum().CompareTo(arr2.Sum());
        }
    }
        [Test]
        public void BubbleSortTest_MaxElement() {
            int[][] result = {new[] {3, -454, 67, 7}, new [] {2, 3, 4}, new[] {1, 2, 3, 0, 4}};

            SortJuggedArray.BubbleSort(_array,new ComparerMaxElement());

            Assert.AreEqual(_array,result);
        }
        [Test]
        public void BubbleSortTest_MaxSumElement()
        {
            int[][] result = {new[] { 1, 2, 3, 0, 4 },  new [] { 2, 3, 4 },new[] { 3, -454, 67, 7 } };

            SortJuggedArray.BubbleSort(_array, new ComparerMaxSumElement());

            Assert.AreEqual(_array, result);
        }
    }
}
