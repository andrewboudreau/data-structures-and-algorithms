using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSA.BinarySearchTree;

namespace DSA.UnitTest
{
  [TestClass]
  public class TraversalTest
  {
    [TestMethod]
    public void Enumerate()
    {
      var tree = new BinarySearchTree<int>() { -1, 0, 1 };
      var itr = tree.GetEnumerator();
      var actual = new List<int>();

      while (itr.MoveNext())
        actual.Add(itr.Current);

      CollectionAssert.AreEquivalent(new int[] { -1, 0, 1 }, actual);
    }

    [TestMethod]
    public void Preorder()
    {
      var tree = new BinarySearchTree<int>() { -1, 0, 1 };
      CollectionAssert.AreEqual(new int[] { -1, 0, 1 }, tree.Preorder.ToList());
    }

    [TestMethod]
    public void Postorder()
    {
      var tree = new BinarySearchTree<int>() { -1, 0, 1 };
      CollectionAssert.AreEqual(new int[] { 1, 0, -1 }, tree.Postorder.ToList());
    }

    [TestMethod]
    public void Inorder()
    {
      var tree = new BinarySearchTree<int>() { 6, 4, 2, 3, 1, 5 };
      CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, tree.Inorder.ToList());
    }

    [TestMethod]
    public void Postorder_Six()
    {
      var tree = new BinarySearchTree<int>() { 6, 4, 2, 3, 1, 5 };
      CollectionAssert.AreEqual(new int[] { 1, 3, 2, 5, 4, 6 }, tree.Postorder.ToList());
    }

    [TestMethod]
    public void Preorder_Six()
    {
      var tree = new BinarySearchTree<int>() { 6, 4, 2, 3, 1, 5 };
      CollectionAssert.AreEqual(new int[] { 6, 4, 2, 1, 3, 5 }, tree.Preorder.ToList());
    }

    [TestMethod]
    public void InorderMedium()
    {
      var tree = new BinarySearchTree<int>() { 0, 6, 4, 2, -1, 3, 1, 5 };
      CollectionAssert.AreEqual(new int[] { -1, 0, 1, 2, 3, 4, 5, 6 }, tree.Inorder.ToList());
    }


  }
}
