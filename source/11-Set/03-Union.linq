<Query Kind="Statements" />

// Union:  merge two sequences, remove all duplicates


var numbersA = new List<int> { 0, 2, 4, 5, 6, 8, 9, 8 }; // 8 items
var numbersB = new List<int> { 1, 3, 5, 7, 8, 9 };       // 6 items

var q = numbersA.Union(numbersB);

q.Dump();