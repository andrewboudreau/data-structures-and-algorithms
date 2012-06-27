namespace DSA
{
  using System.Diagnostics.Contracts;

  public sealed class LinkedListNode<TValue> : INode<TValue>
  {
    public LinkedListNode(TValue value)
    {
      Contract.Requires(value != null);
      Value = value;
    }

    public LinkedListNode<TValue> Next { get; set; }
    public TValue Value { get; set; }
  }
}
