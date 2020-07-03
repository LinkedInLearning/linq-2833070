<Query Kind="Statements" />

// Range:
// Generates a sequence of integral numbers within a specified range.

var numbers = Enumerable.Range(start: 1000, count: 30);

numbers.Dump();

// transform

//var odds = Enumerable.Range(start: 1000, count: 30).Where(e => e % 2 ==1 );
//odds.Dump();