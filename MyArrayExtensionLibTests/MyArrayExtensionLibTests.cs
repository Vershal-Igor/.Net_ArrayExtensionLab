using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyArrayExtensionLib;

namespace MyArrayExtensionLibTests
{
    [TestClass]
    public class MyArrayExtensionLibTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] actual = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int[] expected = { 9, 11, 50, 240, 649, 770, 771, 800 };

            ArrayExtension.BubbleSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void QuickSortTest()
        {
            int[] actual = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int[] expected = { 9, 11, 50, 240, 649, 770, 771, 800 };

            ArrayExtension.QuickSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            int[] actual = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int[] expected = { 9, 11, 50, 240, 649, 770, 771, 800 };

            ArrayExtension.MergeSort(actual);

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
