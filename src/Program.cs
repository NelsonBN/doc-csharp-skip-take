// Skip some elements in a list
var list1 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
var result1 = list1.Skip(3);

// e.g 1: [D, E, F, G]
Console.WriteLine($"e.g 1: [{string.Join(", ", result1)}]");



// Skip more than the collection has
var list2 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
var result2 = list2.Skip(30);

// e.g 2: []
Console.WriteLine($"e.g 2: [{string.Join(", ", result2)}]");




// Skip while a condition is true
var list3 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
var result3 = list3.SkipWhile(c => c < 3);

// e.g 3: [3, 4, 5, 4, 3, 2, 1]
Console.WriteLine($"e.g 3: [{string.Join(", ", result3)}]");


// Notice that in this example all elements are returned because for the first element the condition was false so it stopped skipping immediately on the first element
var list4 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
var result4 = list4.SkipWhile(c => c > 1);

// e.g 3: [1, 2, 3, 4, 5, 4, 3, 2, 1]
Console.WriteLine($"e.g 4: [{string.Join(", ", result4)}]");




// Take some elements from a list
var list5 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
var result5 = list5.Take(4);

// e.g 5: [A, B, C, D]
Console.WriteLine($"e.g 5: [{string.Join(", ", result5)}]");




// Take more than the collection has
var list6 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
var result6 = list6.Take(30);

// e.g 6: [A, B, C, D, E, F, G]
Console.WriteLine($"e.g 6: [{string.Join(", ", result6)}]");




// Take while a condition is true
var list7 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
var result7 = list7.TakeWhile(c => c < 3);

// e.g 7: [1, 2]
Console.WriteLine($"e.g 7: [{string.Join(", ", result7)}]");


// Notice that in this example no elements are returned because the first element  didn't match the condition, so it stopped taking immediately on the first element
var list8 = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
var result8 = list8.TakeWhile(c => c > 4);

// e.g 8: []
Console.WriteLine($"e.g 8: [{string.Join(", ", result8)}]");




// Take a range of elements from a list
var list9 = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
var result9_1 = list9.Take(2..4);
var result9_2 = list9[2..4]; // This syntax is only available for arrays

// e.g 9.1: [C, D, E]
Console.WriteLine($"e.g 9.1: [{string.Join(", ", result9_1)}]");
// e.g 9.2: [C, D, E]
Console.WriteLine($"e.g 9.2: [{string.Join(", ", result9_2)}]");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Some more examples

var sample = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

Console.WriteLine($"[{string.Join(", ", sample.Skip(4))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(3))}]");
Console.WriteLine($"[{string.Join(", ", sample.Skip(2).Take(3))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(2..4))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(..3))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(1..))}]");
//Console.WriteLine($"[{string.Join(", ", sample.Take(0..^1))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(..^1))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(^3..))}]");
Console.WriteLine($"[{string.Join(", ", sample.Take(^5..^2))}]");
