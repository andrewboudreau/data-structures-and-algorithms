using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA.UnitTest
{
  [TestClass]
  public class LinkedListRemoveFirstTest
  {
    public void RemoveFirstTestHelper<T>() where T : new()
    {
      var target = new LinkedList<T>();
      Assert.IsFalse(target.RemoveFirst(new T()));
    }

    [TestMethod()]
    public void RemoveFirstSingleTest()
    {
      RemoveFirstTestHelper<GenericParameterHelper>();
    }

    public void RemoveFirstSingleItemTestHelper<T>() where T : new()
    {
      var target = new LinkedList<T>();
      T value = new T();
      target.Add(value);
      Assert.IsTrue(target.RemoveFirst(value));
    }

    [TestMethod()]
    public void RemoveFirstOnlyItemTest()
    {
      RemoveFirstSingleItemTestHelper<GenericParameterHelper>();
    }

    public void RemoveFirstOfTwoTestHelper<T>() where T : new()
    {
      var target = new LinkedList<T>();
      T value = new T();
      T value2 = new T();
      target.Add(value);
      target.Add(value2);
      Assert.IsTrue(target.RemoveFirst(value));
      CollectionAssert.AreEqual(new T[] { value2 }, target.ToList());
    }

    [TestMethod()]
    public void RemoveFirstOfTwoTest()
    {
      RemoveFirstOfTwoTestHelper<GenericParameterHelper>();
    }

    public void RemoveFirstOfTwoAlternateOrderTestHelper<T>() where T : new()
    {
      var target = new LinkedList<T>();
      T value = new T();
      T value2 = new T();
      target.Add(value2);
      target.Add(value);
      Assert.IsTrue(target.RemoveFirst(value));
      CollectionAssert.AreEqual(new T[] { value2 }, target.ToList());
    }

    [TestMethod()]
    public void RemoveFirstOfTwoAlternateOrderTest()
    {
      RemoveFirstOfTwoAlternateOrderTestHelper<GenericParameterHelper>();
    }

    [TestMethod()]
    public void RemoveFromMiddleTest()
    {
      var target = new LinkedList<int>();

      target.Add(1);
      target.Add(2);
      target.Add(3);
      target.Add(4);
      target.Add(5);

      Assert.IsTrue(target.RemoveFirst(3));
      CollectionAssert.AreEqual(new int[] { 1, 2, 4, 5 }, target.ToList());
    }

    [TestMethod()]
    public void RemoveFromEnd()
    {
      var target = new LinkedList<int>();

      target.Add(1);
      target.Add(2);
      target.Add(3);
      target.Add(4);
      target.Add(5);

      Assert.IsTrue(target.RemoveFirst(5));
      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, target.ToList());
    }

    [TestMethod()]
    public void RemoveFirstNotFound()
    {
      var target = new LinkedList<int>();

      target.Add(1);
      target.Add(2);
      target.Add(3);
      target.Add(4);
      target.Add(5);

      Assert.IsFalse(target.RemoveFirst(0));
      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, target.ToList());
    }

    [TestMethod()]
    public void RemoveFirstWithDupe()
    {
      var target = new LinkedList<int>();

      target.Add(1);
      target.Add(2);
      target.Add(1);
      target.Add(4);
      target.Add(5);

      Assert.IsTrue(target.RemoveFirst(1));
      CollectionAssert.AreEqual(new int[] { 2, 1, 4, 5 }, target.ToList());
    }
  }
}
