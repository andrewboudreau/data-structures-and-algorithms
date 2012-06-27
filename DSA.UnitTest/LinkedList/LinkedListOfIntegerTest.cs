using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA.UnitTest
{
  [TestClass()]
  public class LinkedListOfIntegerTest
  {

    [TestMethod()]
    public void ConstructorDefaults()
    {
      var target = new LinkedList<int>();
      CollectionAssert.AreEqual(new int[] { }, target.ToList());
      Assert.AreEqual(0, target.Count());
    }

    [TestMethod()]
    public void Constructor_NodeParameter()
    {
      var target = new LinkedList<int>() { 0 };
      CollectionAssert.AreEqual(new int[] { 0 }, target.ToList());
      Assert.AreEqual(1, target.Count());
    }

    [TestMethod()]
    public void Constructor_InitializationList()
    {
      var target = new LinkedList<int>() { 1, 2, 3 };
      CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, target.ToList());
      Assert.AreEqual(3, target.Count());
    }

    [TestMethod()]
    public void Constructor_OneHundred()
    {
      var target = new LinkedList<int>() { 100 };
      CollectionAssert.AreEqual(new int[] { 100 }, target.ToList());
      Assert.AreEqual(1, target.Count());
    }

    [TestMethod()]
    public void Constructor_Negative()
    {
      var target = new LinkedList<int>() { -543 };
      CollectionAssert.AreEqual(new int[] { -543 }, target.ToList());
      Assert.AreEqual(1, target.Count());
    }

    [TestMethod()]
    public void ConstructorThenAdd()
    {
      var target = new LinkedList<int>() { 0 };
      target.Add(654);
      CollectionAssert.AreEqual(new int[] { 0, 654 }, target.ToList());
    }

    [TestMethod()]
    public void ConstructorThenAddNegative()
    {
      var target = new LinkedList<int>() { 1297 };
      target.Add(-618);
      CollectionAssert.AreEqual(new int[] { 1297, -618 }, target.ToList());
    }

    [TestMethod()]
    public void ConstructorWithInitializationListThenAdd()
    {
      var target = new LinkedList<int>() { -1, 0, 1 };
      target.Add(100);
      CollectionAssert.AreEqual(new int[] { -1, 0, 1, 100 }, target.ToList());
    }

    [TestMethod()]
    public void ConstructorWithInitializationListThenAddNegative()
    {
      var target = new LinkedList<int>() { -1, 0, 1 };
      target.Add(-618);
      CollectionAssert.AreEqual(new int[] { -1, 0, 1, -618 }, target.ToList());
    }

    [TestMethod()]
    public void GetEnumerator()
    {
      var target = new LinkedList<int>() { -1, 0, 1 };
      var expected = new int[] { -1, 0, 1 };

      var enumerator = target.GetEnumerator();

      var itr = 0;
      while (enumerator.MoveNext())
      {
        Assert.AreEqual(expected[itr], enumerator.Current);
        itr++;
      }
      Assert.AreEqual(3, itr);
    }

  }
}
