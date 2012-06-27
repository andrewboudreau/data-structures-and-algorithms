using DSA.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DSA.UnitTest
{

  [TestClass()]
  public class BinaryNodeTest
  {

    public void BinaryNodeConstructorTestHelper<TValue>() where TValue : new()
    {
      // arrange
      TValue value = new TValue();

      // act
      BinaryNode<TValue> node = new BinaryNode<TValue>(value);
      
      // assert
      Assert.IsNull(node.Left);
      Assert.IsNull(node.Right);
      Assert.AreSame(value, node.Value);
    }

    [TestMethod()]
    public void BinaryNodeConstructorTest()
    {
      BinaryNodeConstructorTestHelper<GenericParameterHelper>();
    }

    public void LeftTestHelper<TValue>() where TValue : new()
    {
      // arrange
      var value = new TValue();
      var otherValue = new TValue();

      var node = new BinaryNode<TValue>(value);
      var otherNode = new BinaryNode<TValue>(otherValue);
      
      // act
      node.Left = otherNode;

      // assert
      Assert.AreSame(node.Left.Value, otherValue);
      Assert.IsNull(node.Right);
    }

    [TestMethod()]
    public void LeftTest()
    {
      LeftTestHelper<GenericParameterHelper>();
    }

    public void RightTestHelper<TValue>() where TValue : new()
    {
      var value = new TValue();
      var otherValue = new TValue();
      var node = new BinaryNode<TValue>(value);
      var otherNode = new BinaryNode<TValue>(otherValue);

      node.Right = otherNode;
      Assert.AreSame(node.Right.Value, otherValue);
      Assert.IsNull(node.Left);
    }

    [TestMethod()]
    public void RightTest()
    {
      RightTestHelper<GenericParameterHelper>();
    }

    public void ValueTestHelper<TValue>() where TValue : new()
    {
      var value = new TValue();
      var node = new BinaryNode<TValue>(value);

      Assert.AreSame(value, node.Value);
    }

    [TestMethod()]
    public void ValueTest()
    {
      ValueTestHelper<GenericParameterHelper>();
    }
  }
}
