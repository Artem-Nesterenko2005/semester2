//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

using System.Collections;
using System.Reflection;
using Test3;

namespace Test3
{
    /// <summary>
    /// class for compare objects
    /// </summary>
    public class Comparator : IComparer
    {
        /// <summary>
        /// method for compare two objects
        /// </summary>
        /// <param name="first">first object</param>
        /// <param name="second">second object</param>
        /// <returns>showing which object is larger or smaller</returns>
        public int Compare(object first, object second)
        {
            return ((new CaseInsensitiveComparer()).Compare(first, second));
        }
    }

    /// <summary>
    /// class for generic bubble sort, using comparator for compare elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericBubbleSort<T>
    {
        /// <summary>
        /// bubble sort for array
        /// </summary>
        /// <param name="array">data array</param>
        /// <param name="comparator">comparator for comparer data from array</param>
        public void BubbleSort(T[] array, Comparator comparator)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
                {
                    if (comparator.Compare(array[j], array[j + 1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}