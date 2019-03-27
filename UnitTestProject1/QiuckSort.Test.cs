using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSortTest3()
        {
            var array = new int[] { 3, 2, 1 };
            QuickSort.Program.QuickSort(array);

            Assert.IsTrue(array[1] > array[0]);
            Assert.IsTrue(array[2] > array[1]);
        }

        [TestMethod]
        public void QuickSortTest100()
        {

            var array = QuickSort.Program.GenerateArray(100);
            bool b = false;

            QuickSort.Program.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= array[i])
                {
                    b = true;
                }
                Assert.AreEqual(b, true);
                b = false;
            }

        }

        [TestMethod]
        public void QuickSortTest1000()
        {
            var array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = 555;
            }

            QuickSort.Program.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], 555);
            }
        }

        [TestMethod]
        public void QuickSortTestNull()
        {
            var array = new int[0];
            bool b = false;

            QuickSort.Program.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= array[i])
                {
                    b = true;
                }
                Assert.AreEqual(b, true);
                b = false;
            }

        }
    }
}

