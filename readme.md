## Data Structures and Algorithms
* 100% test coverage and code contracts
* Generic data strucutes
* Based on the open source DSA e-book, http://dotnetslackers.com/projects/Data-Structures-And-Algorithms/

## Usage Example
```csharp
public void RemoveFirstOfTwoTestHelper<T>() where T : new()
{
  var target = new LinkedList<T>();
  T value = new T();
  T value2 = new T();
  target.Add(value);
  target.Add(value2);
  Assert.IsTrue(target.RemoveFirst(value));
  CollectionAssert.AreEqual(new T[] { value2 }, target.ToList());
}

[TestMethod()]
public void RemoveFirstOfTwoTest()
{
  RemoveFirstOfTwoTestHelper<GenericParameterHelper>();
}
```