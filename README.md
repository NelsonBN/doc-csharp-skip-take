# Skip and Take in Linq of .NET



## What is it?

`Skip()` and `Take()` are simples methods presents in `System.Linq` library of the `.NET` that allows to work with collections in a very expressive way.


### `Skip()`

The `Skip` method allows to skip a number of elements from the beginning of a collection.


#### Skip some elements in a list
```csharp
var list1 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

// [D, E, F, G]
var result1 = list1.Skip(3);
```


#### Skip more than the collection has
If you skip more elements than the collection has, you will get an empty collection.

```csharp
var list2 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

// []
var result2 = list2.Skip(30);
```


#### Skip while a condition is true

```csharp
var list3 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

// [3, 4, 5, 4, 3, 2, 1]
var result3 = list3.SkipWhile(c => c < 3);
```

Notice that in the next example all elements are returned because for the first element the condition was false, so it stopped skipping immediately on the first element.

```csharp
var list4 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

// [1, 2, 3, 4, 5, 4, 3, 2, 1]
var result4 = list4.SkipWhile(c => c > 1);
```


### `Take()`

The `Take` method allows to take a number of elements of a collection.


#### Take some elements from a list
```csharp
var list5 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

// A, B, C, D]
var result5 = list5.Take(4);
```


#### Take more than the collection has
There is no problem to take more elements than the collection has, because the `Take` method will return all elements of the collection.

```csharp
var list6 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

// [A, B, C, D, E, F, G]
var result6 = list6.Take(30);
```


Notice that in this example any elements are returned because the first element that didn't match the condition, so it stopped taking immediately on the first element.
```csharp
var list8 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

// []
var result8 = list8.TakeWhile(c => c > 4);
```


#### Take a range of elements from a list
```csharp
var list9 = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

// [C, D, E]
var result9_1 = list9.Take(2..4);
var result9_2 = list9[2..4]; // This syntax is only available for arrays
```

`list9[2..4]` is the syntax suger for `list9[new Range(2, 4)]`.

The syntax for `Range` is `new Range(start, end)`
- `start` is the index of the first element to be taken (inclusive)
- `end` is the index of the last element to be taken (exclusive)


## Some more examples
```csharp
var sample = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
```

| Syntax            | Result               | Description                                                                              |
|---                |---                   |---                                                                                       |
| `Skip(4)`         | `[E, F, G]`          | Skip the first 4 elements                                                                |
| `Take(3)`         | `[A, B, C]`          | Take the first 3 elements                                                                |
| `Skip(2).Take(3)` | `[A, B, C]`          | Take 3 elements beginning from after the 2nd element                                     |
| `Take(2..4)`      | `[C, D]`             | Take elements beginning from the 2nd to the 4th (Excluding the 4th)                      |
| `Take(..3)`       | `[A, B, C]`          | Take the first 3 elements                                                                |
| `Take(1..)`       | `[B, C, D, E, F, G]` | Skip the first element and take all the rest                                             |
| `Take(..^1)`      | `[A, B, C, D, E, F]` | Take all elements except the last one                                                    |
| `Take(^3..)`      | `[E, F, G]`          | Skip all elements before the 3rd from the end                                            |
| `Take(^5..^2)`    | `[C, D, E]`          | Take elements beginning from the 5th from the end until the 2nd from the end (Excluding) |


## Conclusion
The syntax such as `Range` definitely makes the code cleaner, but that doesn't mean it should be used. Because in some cases it increases the difficulty of interpreting the code by other programmers. The decision to use certain syntaxes (e.g. very recent syntaxes), must consider how much all the team members or people who will maintain the code in the future, are or will be familiarized with the syntax. If you really want to modernize your code, first familiarize your team with new syntax you want to use. That way you ensure that everyone on your team remains productive.