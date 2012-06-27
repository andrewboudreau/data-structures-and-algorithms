using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA.UnitTest
{
  [TestClass]
  public class LinkedListContainsTest
  {
    [TestMethod()]
    public void ContainsIsFalseDefault()
    {
      var target = new LinkedList<int>();
      Assert.IsFalse(target.Contains(1));
    }

    [TestMethod()]
    public void ContainsInt()
    {
      var target = new LinkedList<int>() { 1, 2, 3 };
      Assert.IsTrue(target.Contains(1));
      Assert.IsTrue(target.Contains(2));
      Assert.IsTrue(target.Contains(3));
      Assert.IsFalse(target.Contains(0));
    }

  }
}
