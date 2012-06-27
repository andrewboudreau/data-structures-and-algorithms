namespace DSA.BinarySearchTree
{
  using System.Collections.Generic;
  using System.Diagnostics.Contracts;
  using System;

  /// <summary>
  /// Base class for binary search tree, use this if you need a custom node type.
  /// </summary>
  /// <typeparam name="TValue">Value type of the tree.</typeparam>
  /// <typeparam name="TNode">Node type of tree.</typeparam>
  public class BinarySearchTreeBase<TValue, TNode> : EnumerableNodeBase<TValue, TNode>
    where TNode : IBinaryNode<TValue>, new()
  {

    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/xh5ks3b3.aspx
    /// </summary>
    /// <remarks>
    /// Returns           : Meaning
    /// ------------------:---------------------
    /// Less than zero    : x is less than y.
    /// Zero              : x equals y.
    /// Greater than zero : x is greater than y.
    /// </remarks>
    readonly Comparison<TValue> Compare;

    /// <summary>
    /// Creates a new binary search tree.
    /// </summary>
    public BinarySearchTreeBase() 
      : this(Comparer<TValue>.Default.Compare) 
    { 
    }

    /// <summary>
    /// Creates a new binary search tree and uses the provided compare delegate for all comparisons.
    /// </summary>
    /// <param name="comparison">Delegate to use for comparisons.</param>
    public BinarySearchTreeBase(Comparison<TValue> comparison)
    {
      Contract.Requires(comparison != null);
      Compare = comparison;
    }

    /// <summary>
    /// Inserts a value into the binary search tree.
    /// </summary>
    /// <param name="value"></param>
    public void Add(TValue Value)
    {
      Insert(Value);
    }

    /// <summary>
    /// Inserts a value into the binary search tree.
    /// </summary>
    /// <param name="value"></param>
    public void Insert(TValue value)
    {
      if (Root == null)
        Root = new TNode() { Value = value };
      else
        InsertNode(Root, value);
    }

    /// <summary>
    /// Guides us to the first appropriate place in the tree to put value.
    /// </summary>
    /// <param name="current">Node being investigated.</param>
    /// <param name="value">Value to insert.</param>
    private void InsertNode(TNode current, TValue value)
    {
      Contract.Requires(current != null);
      Contract.Requires(value != null);

      if (Compare(value, current.Value) < 0)
        if (current.Left == null)
          current.Left = new TNode() { Value = value };
        else
          InsertNode((TNode)current.Left, value);
      else
        if (current.Right == null)
          current.Right = new TNode() { Value = value };
        else
          InsertNode((TNode)current.Right, value);
    }

    public bool Contains(TValue value)
    {
      return Contains(Root, value);
    }

    private bool Contains(TNode current, TValue value)
    {
      if (current == null)
        return false;

      if (Compare(current.Value, value) == 0)
        return true;
      else if (Compare(value, current.Value) < 0)
        return Contains((TNode)current.Left, value);
      else
        return Contains((TNode)current.Right, value);
    }

    public IEnumerable<TValue> Inorder
    {
      get
      {
        return InorderStrategy(Root);
      }
    }

    public IEnumerable<TValue> Postorder
    {
      get
      {
        return PostorderStrategy(Root);
      }
    }

    public IEnumerable<TValue> Preorder
    {
      get
      {
        return PreorderStrategy(Root);
      }
    }

    protected virtual IEnumerable<TValue> InorderStrategy(TNode current)
    {
      if (current != null)
      {
        foreach (var tree in InorderStrategy((TNode)current.Left))
          yield return tree;

        yield return current.Value;

        foreach (var tree in InorderStrategy((TNode)current.Right))
          yield return tree;
      }
    }

    protected virtual IEnumerable<TValue> PreorderStrategy(TNode current)
    {
      if (current != null)
      {
        yield return current.Value;

        foreach (var tree in PreorderStrategy((TNode)current.Left))
          yield return tree;

        foreach (var tree in PreorderStrategy((TNode)current.Right))
          yield return tree;
      }
    }

    protected virtual IEnumerable<TValue> PostorderStrategy(TNode current)
    {
      if (current != null)
      {
        foreach (var tree in PostorderStrategy((TNode)current.Left))
          yield return tree;

        foreach (var tree in PostorderStrategy((TNode)current.Right))
          yield return tree;

        yield return current.Value;
      }
    }

    public override IEnumerator<TValue> GetEnumerator()
    {
      return Inorder.GetEnumerator();
    }
  }
}
