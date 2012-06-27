using DSA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DSA.UnitTest
{

  [TestClass()]
  public class SortStrategyTest
  {

    [TestMethod]
    public void InsertionSort()
    {
      // arrange 
      var target = new int[] { 5, 2, 4, 6, 1, 3 };

      // act
      SortStrategy.InsertionSort.Sort(target);

      // assert
      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, target);
    }

    [TestMethod]
    public void InsertionSort_Empty()
    {
      var target = new int[] { };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { }, target);
    }

    [TestMethod]
    public void InsertionSort_Single()
    {
      var target = new int[] { 0 };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { 0 }, target);
    }

    [TestMethod]
    public void InsertionSort_Case1()
    {
      var target = new int[] { 1, 0, -1 };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { -1, 0, 1 }, target);
    }

    [TestMethod]
    public void InsertionSort_Case2()
    {
      var target = new int[] { 1, -1, 0 };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { -1, 0, 1 }, target);
    }

    [TestMethod]
    public void InsertionSort_Case3()
    {
      var target = new int[] { 0, -1, 1 };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { -1, 0, 1 }, target);
    }

    [TestMethod]
    public void InsertionSort_DuplicateZeros()
    {
      var target = new int[] { 0, 0, 0 };
      SortStrategy.InsertionSort.Sort(target);
      CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, target);
    }
  }
}
