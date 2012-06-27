namespace DSA
{
  using System.Collections.Generic;

  /// <summary>
  /// Abstract class providing the foundations for a node based enumerable.
  /// </summary>
  /// <typeparam name="TValue">Node value type.</typeparam>
  /// <typeparam name="TNode">Node type.</typeparam>
  public abstract class EnumerableNodeBase<TValue, TNode> : IEnumerable<TValue> 
    where TNode : INode<TValue>
  {

    protected TNode Root;

    #region IEnumerable

    abstract public IEnumerator<TValue> GetEnumerator();
    
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    #endregion

  }
}
