using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA.UnitTest
{
  [TestClass]
  public class LinkedListAddTest
  {

    public void AddOneTestHelper<T>() where T : new()
    {
      LinkedList<T> target = new LinkedList<T>();
      T value = new T();
      target.Add(value);

      foreach (var item in target)
      {
        Assert.AreSame(value, item);
      }
    }

    [TestMethod()]
    public void AddOneTest()
    {
      AddOneTestHelper<GenericParameterHelper>();
    }

    public void AddAFewTestHelper<T>() where T : new()
    {
      LinkedList<T> target = new LinkedList<T>();
      T value = new T();
      T value2 = new T();
      T value3 = new T();

      target.Add(value);
      target.Add(value);
      target.Add(value2);
      target.Add(value2);
      target.Add(value);
      target.Add(value3);

      var itr = 0;
      var expected = new T[6] { value, value, value2, value2, value, value3 };

      foreach (var item in target)
      {
        Assert.AreSame(expected[itr], item);
        itr++;
      }
      Assert.AreEqual(6, itr);
    }

    [TestMethod()]
    public void AddAFewTest()
    {
      AddAFewTestHelper<GenericParameterHelper>();
    }

    [TestMethod()]
    public void AddZero()
    {
      var target = new LinkedList<int>();
      target.Add(0);
      CollectionAssert.AreEqual(new int[] { 0 }, target.ToList());
    }

    [TestMethod()]
    public void AddNegative()
    {
      var target = new LinkedList<int>();
      target.Add(-1482);
      CollectionAssert.AreEqual(new int[] { -1482 }, target.ToList());
    }

    [TestMethod()]
    public void AddPositive()
    {
      var target = new LinkedList<int>();
      target.Add(15687);
      CollectionAssert.AreEqual(new int[] { 15687 }, target.ToList());
    }

  }
}
