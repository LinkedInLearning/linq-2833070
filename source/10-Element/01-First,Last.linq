<Query Kind="Statements" />

// Returns the first or last element of a sequence.

var numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

numbers.First().Dump("First");
numbers.Last().Dump("Last");
numbers.OrderBy(n => n ).First().Dump("Sorted then First");
numbers.OrderBy(n => n ).Last().Dump("Sorted then Last");

