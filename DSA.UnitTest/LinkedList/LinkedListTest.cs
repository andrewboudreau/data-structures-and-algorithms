using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA;
using System;

namespace DSA.UnitTest
{
  [TestClass()]
  public class LinkedListTest
  {
    public void GetEnumeratorTestHelper<T>()
    {
      IEnumerable target = new LinkedList<T>();
      var enumerator = target.GetEnumerator();

      while (enumerator.MoveNext())
        Assert.Fail("Not expecting items.");
    }

    [TestMethod()]
    [DeploymentItem("DSA.dll")]
    public void GetEnumeratorTest()
    {
      GetEnumeratorTestHelper<GenericParameterHelper>();
    }

    public void GetEnumeratorWithItemsTestHelper<T>()
    {
      var expected = default(T);

      IEnumerable target = new LinkedList<T>() { expected };
      var enumerator = target.GetEnumerator();

      int itr = 0;
      while (enumerator.MoveNext())
      {
        Assert.AreSame(expected, default(T));
        itr++;
      }
      Assert.AreEqual(1, itr);
    }

    [TestMethod()]
    [DeploymentItem("DSA.dll")]
    public void GetEnumeratorWithItemsTest()
    {
      GetEnumeratorTestHelper<GenericParameterHelper>();
    }

  }
}
