namespace DSA.BinarySearchTree
{
  using System;

  public interface IBinaryNode<TValue> : INode<TValue>
  {
    IBinaryNode<TValue> Left { get; set; }
    IBinaryNode<TValue> Right { get; set; }
  }
}
