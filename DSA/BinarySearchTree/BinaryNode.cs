namespace DSA.BinarySearchTree
{
  using System.Diagnostics.Contracts;

  public sealed class BinaryNode<TValue> : IBinaryNode<TValue>, INode<TValue>
  {
    public BinaryNode() { }
    public BinaryNode(TValue value)
    {
      Contract.Requires(value != null);
      Value = value;
    }

    public IBinaryNode<TValue> Left { get; set; }
    public IBinaryNode<TValue> Right { get; set; }

    public TValue Value { get; set; }
  }
}