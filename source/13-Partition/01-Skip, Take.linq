<Query Kind="Statements" />

// Take:  Get a consecutive subset of the sequence
// Skip:  Skip a consecutive subset of the sequence
var numbers = Enumerable.Range(1, 50);

numbers.Take(5).Dump("Take 5");

numbers.Skip(46).Dump("Skip 46");
numbers.Skip(numbers.Count() - 12).Dump("Skip based on count");
numbers.Skip(11).Take(3).Dump("Skip 11, Take 3");

numbers.Skip(2).Take(10).Dump("Skip 2, Take 10");