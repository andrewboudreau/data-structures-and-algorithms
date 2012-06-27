using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA.BinarySearchTree;

namespace DSA.UnitTest
{
  [TestClass]
  public class ContainsTest
  {
    [TestMethod]
    public void Contains()
    {
      var tree = new BinarySearchTree<int>() { 0, 6, 4, 2, -1, 3, 1, 5 };
      Assert.IsFalse(tree.Contains(-2));
      Assert.IsTrue(tree.Contains(-1));
      Assert.IsTrue(tree.Contains(0));
      Assert.IsTrue(tree.Contains(1));
      Assert.IsTrue(tree.Contains(2));
      Assert.IsTrue(tree.Contains(3));
      Assert.IsTrue(tree.Contains(4));
      Assert.IsTrue(tree.Contains(5));
      Assert.IsTrue(tree.Contains(6));
      Assert.IsFalse(tree.Contains(7));
    }
  }
}
