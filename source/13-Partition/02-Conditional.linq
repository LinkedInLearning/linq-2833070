<Query Kind="Statements" />

// TakeWhile: Returns elements from a sequence 
// as long as a specified condition is true, 
// and then skips the remaining elements.

// SkipWhile:  Bypasses elements in a sequence
// as long as a specified condition is true 
// and then returns the remaining elements.

var numbers = new List<int> { 21, 32, 43, 54, 65, 201, 301, 401, 76, 87, 98 };

numbers.TakeWhile(x => x <100 ).Dump();

numbers.SkipWhile(x => x <100 ).Dump();