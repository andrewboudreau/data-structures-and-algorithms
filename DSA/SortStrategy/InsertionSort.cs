namespace DSA.SortStrategy
{
  using System.Collections.Generic;
  using System.Diagnostics.Contracts;
  using System;

  public static class InsertionSort
  {
    /// <summary>
    /// Insertion sort is a somewhat interesting algorithm with an expensive runtime of O(n2). It can be best thought of as a sorting scheme similar to that of sorting a hand of playing cards, i.e. you take one card and then look at the rest with the intent of building up an ordered set of cards in your hand.    
    /// </summary>
    /// <typeparam name="T">Type of item being sorted.</typeparam>
    /// <returns>The sorted array.</returns>
    public static IList<T> Sort<T>(this IList<T> array)
    {
      Contract.Requires(array != null);
      return Sort<T>(array, Comparer<T>.Default);
    }

    /// <summary>
    /// Sorts an array using an insertion sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of item being sorted.</typeparam>
    /// <param name="array">Array of items to sort.</param>
    /// <param name="comparer"><see cref="IComparer"/> to use for sort comparisons.</param>
    /// <returns>The sorted array.</returns>
    public static IList<T> Sort<T>(this IList<T> array, IComparer<T> comparer)
    {
      Contract.Requires(array != null);
      Contract.Requires(comparer != null);

      return Sort<T>(array, (lhs, rhs) => comparer.Compare(lhs, rhs));
    }

    /// <summary>
    /// Sorts an array using an insertion sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of item being sorted.</typeparam>
    /// <param name="array">Array of items to sort.</param>
    /// <param name="comparer"><see cref="IComparer"/> to use for sort comparisons.</param>
    /// <returns>The sorted array.</returns>
    public static IList<T> Sort<T>(this IList<T> array, Comparison<T> compare)
    {
      Contract.Requires(array != null);
      Contract.Requires(compare != null);

      var itr = 1;
      while (itr < array.Count)
      {
        var current = array[itr];
        var peek = itr - 1;
        while (peek >= 0 && compare(current, array[peek]) < 0)
        {
          array[peek + 1] = array[peek];
          peek = peek - 1;
        }
        array[peek + 1] = current;
        itr = itr + 1;
      }
      return array;
    }
  }
}
