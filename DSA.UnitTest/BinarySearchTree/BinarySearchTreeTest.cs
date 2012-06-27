using DSA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DSA.UnitTest
{
  
  [TestClass()]
  public class BinarySearchTreeTest
  {

    [TestMethod()]
    public void EmptyBST()
    {
      var tree = new BinarySearchTree.BinarySearchTree<int>();
      Assert.AreEqual(0, tree.Count());
    }
  }

}
