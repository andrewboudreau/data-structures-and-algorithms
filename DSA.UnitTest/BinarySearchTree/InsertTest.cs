using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSA.UnitTest
{
  [TestClass]
  public class InsertTest
  {
    [TestMethod]
    public void Insert()
    {
      var tree = new BinarySearchTree.BinarySearchTree<int>();
      tree.Insert(0);
      CollectionAssert.AreEqual(new int[] { 0 }, tree.ToList());
    }

    [TestMethod]
    public void InsertAFew()
    {
      var tree = new BinarySearchTree.BinarySearchTree<int>();
      tree.Add(-1);
      tree.Add(0);
      tree.Add(1);
      CollectionAssert.AreEquivalent(new int[] { -1, 0, 1 }, tree.ToList());
    }

    [TestMethod]
    public void Insert_InitializationList()
    {
      var tree = new BinarySearchTree.BinarySearchTree<int>() { -1, 0, 1 };
      CollectionAssert.AreEquivalent(new int[] { -1, 0, 1 }, tree.ToList());
    }

  }
}
