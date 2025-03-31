using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsForConsoleApp
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ThirdSemesterIT.A12Sorting;

    namespace Sortering.Tests
    {
        [TestClass]
        public class SortingTests
        {
            [TestMethod]
            public void TestBubbleSort()
            {
                int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
                BubbleSort.Sort(array);
                CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67 }, array);
            }

            [TestMethod]
            public void TestInsertionSort()
            {
                int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
                InsertionSort.Sort(array);
                CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67 }, array);
            }

            [TestMethod]
            public void TestSelectionSort()
            {
                int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
                SelectionSort.Sort(array);
                CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67 }, array);
            }

            [TestMethod]
            public void TestQuickSort()
            {
                int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
                QuickSort.Sort(array);
                CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67 }, array);
            }

            [TestMethod]
            public void TestMergeSort()
            {
                int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
                MergeSort.Sort(array);
                CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67 }, array);
            }
        }
    }
}
