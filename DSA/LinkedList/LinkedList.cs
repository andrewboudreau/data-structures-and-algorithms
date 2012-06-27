namespace DSA
{
  using System.Diagnostics.Contracts;

  /// <summary>
  /// A singly linked list.
  /// </summary>
  /// <typeparam name="T">Type of node in the list.</typeparam>
  public class LinkedList<T> : EnumerableNodeBase<T, LinkedListNode<T>>
  {
    LinkedListNode<T> Tail { get; set; }

    /// <summary>
    /// Creates an empty linked list.
    /// </summary>
    public LinkedList()
    {
      Root = default(LinkedListNode<T>);
      Tail = default(LinkedListNode<T>);
    }
    
    /// <summary>
    /// Adds <paramref name="value"/> to the end of the linked list.
    /// </summary>
    /// <param name="value">Value to add.</param>
    public void Add(T value)
    {
      Contract.Requires(value != null);
      var node = new LinkedListNode<T>(value);
      if (Root == default(LinkedListNode<T>))
        Root = Tail = node;
      else
      {
        Tail.Next = node;
        Tail = node;
      }
    }

    /// <summary>
    /// Returns true if <paramref name="value"/> is found in the collection, false otherwise.
    /// </summary>
    /// <param name="value">Value to find.</param>
    public bool Contains(T value)
    {
      Contract.Requires(value != null);
      if (Root == default(LinkedListNode<T>))
        return false;

      var current = Root;
      while (current != default(LinkedListNode<T>) && !current.Value.Equals(value))
        current = current.Next;

      return current != default(LinkedListNode<T>);
    }

    /// <summary>
    /// Removes the first instance of <typeparamref name="T"/>.
    /// </summary>
    /// <param name="value">Values to remove from the linked list.</param>
    public bool RemoveFirst(T value)
    {
      if (Root == default(LinkedListNode<T>))
        return false;

      var current = Root;
      if (current.Value.Equals(value))
      {
        if (Root.Equals(Tail))
        {
          Root = default(LinkedListNode<T>);
          Tail = default(LinkedListNode<T>);
        }
        else
          Root = Root.Next;
        return true;
      }

      while (current.Next != default(LinkedListNode<T>) && !current.Next.Value.Equals(value))
        current = current.Next;

      if (current.Next != default(LinkedListNode<T>))
      {
        if (current.Next == Tail)
          Tail = current;

        current.Next = current.Next.Next;
        return true;
      }

      return false;
    }

    public override System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
      {
        var current = Root;
        if (current == null)
          yield break;

        do
          yield return current.Value;
        while ((current = current.Next) != null);
      }
    }
  }
}
