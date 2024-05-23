//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

using System.Diagnostics.Metrics;
using System.Reflection;
using Test3;
namespace Test
{
    public class Tests
    {
        [Test]
        public void TestintData()
        {
            int counter = 0;
            GenericBubbleSort<int> sort = new();
            int[] array = { 1, 5, 2, 4, 3 };
            Comparator comparator = new();
            int[] rightArray = { 1, 2, 3, 4, 5 };
            sort.BubbleSort(array, comparator);
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != rightArray[i])
                {
                    ++counter;
                }
            }
            Assert.IsTrue(counter == 0);
        }

        [Test]
        public void TestCharData()
        {
            int counter = 0;
            GenericBubbleSort<char> sort = new();
            char[] array = { 'c', 'g', 'z', '1', 'v' };
            Comparator comparator = new();
            char[] rightArray = { 'c', 'g', 'z', '1', 'v' };
            sort.BubbleSort(array, comparator);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != rightArray[i])
                {
                    ++counter;
                }
            }
            Assert.IsTrue(counter == 0);
        }
    }
}